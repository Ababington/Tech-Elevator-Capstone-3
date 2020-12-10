using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class OfficeSqlDAO
    {
        private readonly string connectionString;

        public OfficeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
    }
}
