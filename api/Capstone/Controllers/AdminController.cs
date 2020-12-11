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
    public class AdminController:ControllerBase
    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        public AdminController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
        }


        [HttpGet("/getPendingDoctors")]
        public ActionResult<List<User>> GetPendingDoctors()
        {
            try
            {
                List<User> pendingDoctors = userDAO.GetPendingDoctors();
                return pendingDoctors;
            }
            catch(Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpPost("/createNewOffice")]
        public ActionResult<Office> CreateNewOffice(Office office)
        {
            try
            {
                addressDAO.CreateNewOfficeAddress(office);

            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
