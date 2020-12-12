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
            try
            {
                Doctor infoDoc = doctorDAO.GetmyInfo(doctor);
                return infoDoc;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpPut("myinfo/update")]
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
        [HttpGet("myOffices")]
        public ActionResult<Office> GetMyOffices(Office office )
        {
            try
            {
                Office myOffice = officeDAO.GetMyOffices(office);
                return myOffice;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpGet("myOffices/${office.id}/reviews")]
        public ActionResult<Office> GetMyOfficeReviews(Office office)
        {
            try
            {
                Office myOfficeReviews = officeDAO.GetMyOfficeReviews(office);
                return myOfficeReviews;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpGet("myOffices/${office.id}/reviews/responses")]
        public ActionResult<Office> GetReviewResponses(Office office)
        {//user? or office?
            try
            {
                Office reviewResponse = officeDAO.GetReviewResponses(office);
                return office;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpGet("getAppointments")]
        public ActionResult<Appointments> GetAppointments(Appointments appointments)
        {
            try
            {
                Appointments respondAppt = appointmentDAO.GetAppointments(appointments);
                return appointments;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpPut("getAppointments/respondToPending")]
        public ActionResult<Appointments> RespondToPendingAppointment(Appointments appointments)
        {
            try
            {
                Appointments respondAppt = appointmentDAO.RespondToPendingAppointment(appointments);
                return appointments;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }






    }
}
