using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class DoctorSqlDAO
    {
        private readonly string connectionString;

        public DoctorSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
    }
}
