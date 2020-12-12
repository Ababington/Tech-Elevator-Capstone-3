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
        [HttpGet("getDoctorAvailability")]
        public ActionResult<List<Doctor>> GetDoctorAvailability()
        {
           //sheleton
                throw new NotImplementedException("This method is not implemented");
            
        }

        [HttpPost("bookAppointment")]
        public ActionResult<string> BookAppointment()
        {
            //nothing at all here
            throw new NotImplementedException("This method is not implemented");

        }
        [HttpGet("seeReviews")]
        public ActionResult<string> ReadReviews()
        {
            //i will be sad if we dont use these
            throw new NotImplementedException("This method is not implemented");

        }
        [HttpPost("postReviews")]
        public ActionResult<string> PostReviews()
        {
            throw new NotImplementedException("This method is not implemented");

        }
    }
}
