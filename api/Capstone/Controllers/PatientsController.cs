using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase

    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        private readonly IOfficeAddressDAO officeAddressDAO;
        private readonly IDoctorDAO doctorDAO;
        private readonly IReviewDAO reviewDAO;
        private readonly IAppointmentDAO appointmentDAO;
        private readonly IPatientsDAO patientsDAO;

        public PatientsController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO, IReviewDAO _reviewDAO, IAppointmentDAO _appointmentDAO, IPatientsDAO _patientsDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
            reviewDAO = _reviewDAO;
            appointmentDAO = _appointmentDAO;
            patientsDAO = _patientsDAO;
        }

        [HttpGet("getDoctors")] //Done
        public ActionResult<List<Doctor>> GetVerifiedDoctors()
        {
            try
            {
                List<Doctor> verifiedDoctors = doctorDAO.GetAllDoctors();
                return verifiedDoctors;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("getOffices")]
        public ActionResult<List<Office>> GetAllOffices()
        {
            try
            {
                List<Office> allOffices = officeDAO.GetAllOffices();
                foreach(Office office in allOffices)
                {
                    office.DocsInOffice = doctorDAO.GetDoctorsByOffice(office.OfficeId);
                }
                return allOffices;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("getOffices/{doctorId}")] //Done
        public ActionResult<List<Office>> GetOfficesByDoctor(int doctorId)
        {
            try
            {
                List<Office> officesByDoctor = officeDAO.GetMyOffices(doctorId);
                foreach(Office office in officesByDoctor)
                {
                    office.DocsInOffice = doctorDAO.GetOtherDoctorsInOffice(office.OfficeId, doctorId);
                }
                return officesByDoctor;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpGet("getReviews/{officeId}")] //done
        public ActionResult <List<Review>> GetOfficeReviews(int officeId)
        {
           
            try
            {
                List<Review> officeReview = reviewDAO.GetOfficeReviews(officeId);
                return officeReview;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
            throw new NotImplementedException("This method is not implemented");

        }

        [HttpPost("postReview")]//done
        public ActionResult<Review> PostReview(Review review)
        {
            try
            {
              Review newReview = reviewDAO.PostNewReview(review);

                return review;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("{patientId}")] //done
        public ActionResult<Patient> GetMyInfo(int patientId)
        {
            try
            {
                Patient infoPat = patientsDAO.GetMyInfo(patientId);
                return infoPat;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpPut("{patientId}/updateInfo")] //done
        public ActionResult<Patient> UpdateMyInfo(Patient patients)
        {
            
            try
            {
                Patient updatePat = patientsDAO.UpdateMyInfo(patients);
                return updatePat;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("{patientId}/appointments")] //Done
        public ActionResult<List<Appointment>> GetMyAppointments(int patientId)
        {
            try
            {
                List<Appointment> patientAppts = appointmentDAO.GetAppointmentsByPatient(patientId);
                return patientAppts;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost("requestAppointment")] //done
        public ActionResult<Appointment> CreateAppointmentRequest(Appointment appointment)
        {
            try
            {
                DayOfWeek day = appointment.Date.DayOfWeek;
                string dayString = Convert.ToString(day);
                Doctor doctor = doctorDAO.GetmyInfo(appointment.DoctorId);
                bool isWorking = false;
                if(dayString == "Monday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Monday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Monday.End) >= Convert.ToInt32(appointment.Time);
                }
                else if (dayString == "Tuesday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Tuesday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Tuesday.End) >= Convert.ToInt32(appointment.Time);
                }
                else if (dayString == "Wednesday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Wednesday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Wednesday.End) >= Convert.ToInt32(appointment.Time);
                }
                else if (dayString == "Thursday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Thursday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Thursday.End) >= Convert.ToInt32(appointment.Time);
                }
                else if (dayString == "Friday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Friday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Friday.End) >= Convert.ToInt32(appointment.Time);
                }
                else if (dayString == "Saturday")
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Saturday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Saturday.End) >= Convert.ToInt32(appointment.Time);
                }
                else
                {
                    isWorking = Convert.ToInt32(doctor.WeeklyHours.Sunday.Start) <= Convert.ToInt32(appointment.Time)
                        && Convert.ToInt32(doctor.WeeklyHours.Sunday.End) >= Convert.ToInt32(appointment.Time);
                }

                if(isWorking)
                {
                    List<Appointment> docAppts = appointmentDAO.GetAppointmentsByDoctor(appointment.DoctorId);
                    bool isAvailable = true;
                    TimeSpan appointmentTime = new TimeSpan(0, 30, 0);
                    foreach(Appointment a in docAppts)
                    {
                        if ( (a.Time >= appointment.Time && a.Time < appointment.Time.Add(appointmentTime)) || 
                            (a.Time.Add(appointmentTime) > appointment.Time && a.Time.Add(appointmentTime) <= appointment.Time.Add(appointmentTime)) )
                        {
                            isAvailable = false;
                        }
                    }

                    if(isAvailable)
                    {
                        Appointment newAppt = appointmentDAO.CreateAppointmentRequest(appointment);
                        return Ok(newAppt);
                    }
                    else
                    {
                        return Conflict();
                    }
                }
                else
                {
                    return Conflict();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500);
            }
        }
    }
}
