using Capstone.DAO;
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

        public DoctorController(IUserDAO _userDAO)
        {
            userDAO = _userDAO;
        }
    }
}
