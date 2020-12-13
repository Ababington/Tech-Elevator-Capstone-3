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

        public PatientsController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
        }

        [HttpGet("getVerifiedDoctors")]
        public ActionResult<List<Doctor>> GetVerifiedDoctors()
        {
            try
            {
                List<Doctor> verifiedDoctors = doctorDAO.GetAllDoctors();
                return verifiedDoctors;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("patient/{patientId}")]
        public ActionResult<Patient> GetMyInfo(int patientId)
        {
            throw new NotImplementedException();
        }

        [HttpPut("/patient/updateInfo")]
        public ActionResult<Patient> UpdateMyInfo(Patient patients)
        {
            throw new NotImplementedException();
        }

        [HttpGet("patient/allOffices")]
        public ActionResult<List<Office>> GetAllOffices(Office office)
        {
            throw new NotImplementedException();
        }

        [HttpGet("patient/allOffices/{officeId}/reviews")]
        public ActionResult<Office> GetOfficeReviews(int officeId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("patient/allOffices/{officeId}/reviews/responses")]
        public ActionResult<Office> GetReviewResponses(Office office)
        {
            throw new NotImplementedException();
        }

        [HttpPost("patient/allOffices/postReview")]
        public ActionResult<Office> PostNewReview(Office office)
        {
            //todo make review model???? and sqldao
            throw new NotImplementedException();
        }

        [HttpGet("patient/{patientId}/appointments")]
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
