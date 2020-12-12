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
    public class DoctorController : ControllerBase

    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        private readonly IOfficeAddressDAO officeAddressDAO;
        private readonly IDoctorDAO doctorDAO;
        public DoctorController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
        }



        public DoctorController(IUserDAO _userDAO)
        {
            userDAO = _userDAO;
        }

        [HttpGet]
        public ActionResult<string> BaseDoctorTest()
        {
            return Ok("reached doctor");
        }
        [HttpGet("myInfo")]
        public ActionResult<Doctor> GetmyInfo(Doctor doctor)
        {
            return doctor;
        }
        [HttpPut("myinfo/update")]
            public ActionResult<Doctor> UpdateMyInfo(Doctor doctor)
        {
            return doctor;
        }









        //ignore below for now still updating doc 
        [HttpPut("updateHourlyRate")]
        public ActionResult<decimal> UpdateHourlyRate()
        {
            return 1;
        }
        [HttpPut("updateDoctorAvailability")]
        public ActionResult<int> UpdateDoctorAvailability()
        {
            //datetime?
            return 1;
        }
        [HttpGet("getOfficeHours")]
        public ActionResult<int> GetOfficeHours()
        {
            //datetime
            return 1;
        }
        [HttpGet("getDoctorAppointments")]
        public ActionResult<string> GetDoctorAppointments()
        {
            return "helpme";
        }
        [HttpPost("createSchedule")]
        public ActionResult<string> CreateSchdule()
        {
            return "foemf";
        }
        [HttpGet("seeReviewRespond")]
        public ActionResult<string> SeeReviewRespond()
        {
            return "do we need two https one for seeing reviews and one for updating them?";
        }
    }
}
