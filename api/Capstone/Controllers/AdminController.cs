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
    public class AdminController : ControllerBase
    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        private readonly IOfficeAddressDAO officeAddressDAO;
        public AdminController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
        }

        [HttpGet]
        public ActionResult<string> BaseAdminTest()
        {
            return Ok("reached admin");
        }

        [HttpGet("getPendingDoctors")]
        public ActionResult<List<User>> GetPendingDoctors()
        {
            try
            {
                List<User> pendingDoctors = userDAO.GetPendingDoctors();
                return pendingDoctors;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
        [HttpPost("createNewOffice")]
        public ActionResult<Office> CreateNewOffice(Office office)
        {
            try
            {
                int? newOfficeId = officeDAO.CreateNewOffice(office);
                if (newOfficeId != null)
                {
                   int newOfficeIdNotNull = (int)(newOfficeId); 
                    
                    int? newAddressId = addressDAO.CreateNewOfficeAddress(office);

                    if (newAddressId != null)
                    {
                        int newAddressIdNotNull = (int)(newAddressId);
                        officeAddressDAO.AddOfficeAddress( newOfficeIdNotNull, newAddressIdNotNull);
                        office.OfficeId = newOfficeIdNotNull;
                        return Ok(office);
                    }
                    else
                    {
                        //if address sql fails
                        return BadRequest();
                    }
                }
                else
                {
                    //if office sql fails
                    return BadRequest();
                }

            }
            catch (Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
