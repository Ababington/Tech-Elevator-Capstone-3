using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IAppointmentDAO
    {
        List<Appointment> GetAppointments(int userId);
        bool RespondToPendingAppointment(Appointment appointment);
        bool CreateAppointmentRequest(Appointment appointment);

    }
}
