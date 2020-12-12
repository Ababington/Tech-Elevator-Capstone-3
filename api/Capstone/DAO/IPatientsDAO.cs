using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IPatientsDAO
    {
        string GetDoctorAvailability(Doctor doctor);
        string BookAppointment();
        string ReadReviews();
        string PostReviews();
    }
}
