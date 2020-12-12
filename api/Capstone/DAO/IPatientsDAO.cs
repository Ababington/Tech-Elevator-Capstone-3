using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IPatientsDAO
    {
        Patients GetMyInfo(Patients patients);
        Patients UpdateMyInfo(Patients patients);
        Patients GetMyAppointments(Patients patients);
    }
}
