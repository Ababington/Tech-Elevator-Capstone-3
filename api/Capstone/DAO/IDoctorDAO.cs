using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IDoctorDAO
    {
        decimal UpdateDoctorRates(Doctor doctor);
        int UpdateDoctorAvailability(Doctor doctor);
        int GetOfficeHours(int id);
        string GetMyDoctorAppointments();
        string SeeReviewRespond();
    }
}
