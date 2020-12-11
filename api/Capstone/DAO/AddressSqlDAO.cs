using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class AddressSqlDAO : IAddressDAO
    {
        private readonly string connectionString;
        public AddressSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public int CreateNewOfficeAddress(Office office)
        {
            return 1;
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("", conn);
            //        SqlDataReader reader = cmd.ExecuteReader();

            //    }
            //}
        }
    }
}



