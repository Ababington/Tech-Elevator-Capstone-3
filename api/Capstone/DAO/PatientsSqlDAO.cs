using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class PatientsSqlDAO : IPatientsDAO
    {
        private readonly string connectionString;

        public PatientsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Patient GetMyAppointments(Patient patients)
        {
            throw new NotImplementedException();
        }

        public Patient GetMyInfo(Patient patients)
        {
            throw new NotImplementedException();
        }

        public Patient UpdateMyInfo(Patient patients)
        {
            throw new NotImplementedException();
        }
    }
}
