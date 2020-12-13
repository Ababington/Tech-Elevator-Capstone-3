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
        private readonly IAppointmentDAO appointmentDAO;
        public DoctorController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO, IAppointmentDAO _appointmentDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
            appointmentDAO = _appointmentDAO;
        }

        //TODO ***********ADD DOCTOR/DAY INFO, AS WELL AS OFFICE/DAY
        //Note: when altering the doctor times, we also need to grab the office they work at on that day, and then we can make sure those 2 ids (doc and office) are on the linking table



        [HttpGet]
        public ActionResult<string> BaseDoctorTest()
        {
            return Ok("reached doctor");
        }

        [HttpGet("{userId}/myInfo")] //Done
        public ActionResult<Doctor> GetmyInfo(int userId)
        {
            try
            {
                Doctor infoDoc = doctorDAO.GetmyInfo(userId);
                return infoDoc;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpPut("{userId}/myInfo/update")] //Done
        public ActionResult<Doctor> UpdateMyInfo(Doctor doctor)
        {
            try
            {
                Doctor updateDoc = doctorDAO.UpdateMyInfo(doctor);
                return updateDoc;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("{userId}/myOffices")] //Done
        public ActionResult<List<Office>> GetMyOffices(int userId)
        {
            try
            {
                List<Office> myOffice = officeDAO.GetMyOffices(userId);
                return myOffice;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpGet("myOffices/{officeId}/reviews")]
        public ActionResult<Office> GetMyOfficeReviews(int officeId)
        {
            throw new NotImplementedException("This method is not implemented");
        }

        [HttpGet("myOffices/{officeId}/reviews/responses")]
        public ActionResult<Office> GetReviewResponses(Office office)
        {//user? or office?
            throw new NotImplementedException("This method is not implemented");
        }

        [HttpGet("userId/getAppointments")]
        public ActionResult<List<Appointment>> GetAppointments(int userId)
        {
            try
            {
                List<Appointment> respondAppt = appointmentDAO.GetAppointments(userId);
                return respondAppt;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpPut("getAppointments/respondToPending")]
        public ActionResult<bool> RespondToPendingAppointment(Appointment appointment)
        {
            try
            {
                bool respondAppt = appointmentDAO.RespondToPendingAppointment(appointment);
                return respondAppt;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
