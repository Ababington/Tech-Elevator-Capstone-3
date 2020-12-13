using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IPatientsDAO
    {
        Patient GetMyInfo(Patient patients);
        Patient UpdateMyInfo(Patient patients);
        Patient GetMyAppointments(Patient patients);
    }
}
