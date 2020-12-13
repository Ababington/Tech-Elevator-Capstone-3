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

        public PatientsController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO, IReviewDAO _reviewDAO, IAppointmentDAO _appointmentDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
            reviewDAO = _reviewDAO;
            appointmentDAO = _appointmentDAO;
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

        [HttpGet("getOfficesByDoctor/{doctorId}/{officeId}")] //Gets reviews + doctors in office for specific office
        public ActionResult<Office> GetOfficeReviews(int officeId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("postReview")]
        public ActionResult<Review> PostReview(Review review)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{patientId}")] //Get info
        public ActionResult<Patient> GetMyInfo(int patientId)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{patientId}/updateInfo")]
        public ActionResult<Patient> UpdateMyInfo(Patient patients)
        {
            throw new NotImplementedException();
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

        [HttpPost("{patient}/requestAppointment")]
        public ActionResult<Appointment> CreateAppointmentRequest(Appointment appointments)
        {
            throw new NotImplementedException();
        }
    }
}
