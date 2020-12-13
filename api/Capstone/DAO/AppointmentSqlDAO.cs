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

        public bool CreateAppointmentRequest(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointments(int userId)
        {
            throw new NotImplementedException();
        }

        public bool RespondToPendingAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
