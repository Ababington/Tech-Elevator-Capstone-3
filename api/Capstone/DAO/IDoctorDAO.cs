using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IDoctorDAO
    {
        Doctor GetmyInfo(Doctor doctor);
        Doctor UpdateMyInfo(Doctor doctor);
        string ApproveDoctorUser(Doctor doctor);
        //from patient controller
        Doctor GetAllDoctors(Doctor doctor);

    }
}
