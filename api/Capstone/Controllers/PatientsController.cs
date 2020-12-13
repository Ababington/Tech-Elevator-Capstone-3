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

        public PatientsController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO, IReviewDAO _reviewDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
            reviewDAO = _reviewDAO;
        }

        [HttpGet("getVerifiedDoctors")]
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

        [HttpGet("{patientId}")] //Get info??
        public ActionResult<Patient> GetMyInfo(int patientId)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{patientId}/updateInfo")]
        public ActionResult<Patient> UpdateMyInfo(Patient patients)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{patientId}/allOffices")]
        public ActionResult<List<Office>> GetAllOffices(Office office)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{patientId}/allOffices/{officeId}/reviews")]
        public ActionResult<Office> GetOfficeReviews(int officeId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{patientId}/allOffices/{officeId}/reviews/responses")]
        public ActionResult<Office> GetReviewResponses(Office office)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{patientId}/allOffices/postReview")]
        public ActionResult<Office> PostNewReview(Office office)
        {
            //todo make review model???? and sqldao
            throw new NotImplementedException();
        }

        [HttpGet("{patientId}/appointments")]
        public ActionResult<Patient> GetMyAppointments(int patientId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("patient/requestAppointment")]
        public ActionResult<Appointment> CreateAppointmentRequest(Appointment appointments)
        {
            throw new NotImplementedException();
        }
    }
}
