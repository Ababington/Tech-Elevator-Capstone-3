using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class AppointmentSqlDAO : IAppointmentDAO
    {
        private readonly string connectionString;
        public AppointmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Appointments CreateAppointmentRequest(Appointments appointments)
        {
            throw new NotImplementedException();
        }

        public Appointments GetAppointments(Appointments appointments)
        {
            throw new NotImplementedException();
        }

        public Appointments RespondToPendingAppointment(Appointments appointments)
        {
            throw new NotImplementedException();
        }
    }
}
