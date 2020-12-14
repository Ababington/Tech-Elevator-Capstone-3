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

        [HttpGet("getOfficesByDoctor/{doctorId}")] //Done
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

        [HttpGet("getOfficesByDoctor/{doctorId}/{officeId}")] //done
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

        [HttpPost("{patient}/requestAppointment")] //done
        public ActionResult<Appointment> CreateAppointmentRequest(Appointment appointments)
        {
            try
            {
                Appointment newAppt = appointmentDAO.CreateAppointmentRequest(appointments);
                return appointments;
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
