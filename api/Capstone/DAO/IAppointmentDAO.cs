using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IAppointmentDAO
    {
        Appointments GetAppointments(Appointments appointments);


        Appointments RespondToPendingAppointment(Appointments appointments);
        Appointments CreateAppointmentRequest(Appointments appointments);

    }
}
