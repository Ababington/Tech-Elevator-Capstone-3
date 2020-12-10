using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class AddressSqlDAO
    {
        private readonly string connectionString;
        public AddressSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

    }
}
