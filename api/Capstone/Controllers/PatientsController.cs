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
        public ActionResult<List<User>> GetVerifiedDoctors()
        {
            try
            {
                List<User> verifidDoctors = userDAO.GetVerifiedDoctors();
                return verifidDoctors;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
       

        [HttpGet("patient/${patient.id}")]
        public ActionResult<Patients> GetMyInfo(Patients patients)
        {
            return patients;
        }
        [HttpPut("/patient/updateInfo")]
        public ActionResult<Patients> UpdateMyInfo(Patients patients)
        {
            return patients;
        }
        [HttpGet("patient/allOffices")]
        public ActionResult<Office> GetAllOffices(Office office)
        {
            return office;
        }
        [HttpGet("patient/allOffices/${office.id}/reviews")]
        public ActionResult<Office> GetOfficeReviews(Office office)
        {
            return office;
        }
        [HttpGet("patient/allOffices/${office.id}/reviews/responses")]
        public ActionResult<Office> GetReviewResponses(Office office)
        {
            return office;
        }
        [HttpPost("patient/allOffices/postReview")]
        public ActionResult<Office> PostNewReview(Office office)
        {
            //todo make review model???? and sqldao
            return office;
        }
        [HttpGet("patient/doctorsList")]
        public ActionResult<Doctor> GetAllDoctors(Doctor doctor)
        {
            return doctor;
        }
        [HttpGet("patient/${patient.id}/appointments")]
        public ActionResult<Patients> GetMyAppointments(Patients patients)
        {
            return patients;
        }
        [HttpPost("patient/requestAppointment")]
        public ActionResult<Appointments> CreateAppointmentRequest(Appointments appointments)
        {
            return appointments;
        }



    }
}
