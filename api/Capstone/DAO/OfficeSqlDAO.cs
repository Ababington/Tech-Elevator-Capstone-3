using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class OfficeSqlDAO : IOfficeDAO
    {
        private readonly string connectionString;

        public OfficeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public int CreateNewOffice(Office office)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into office (phone, name) values (@phone, @name); select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@phone", office.PhoneNumber);
                    cmd.Parameters.AddWithValue("@name", office.Name);

                    object result = cmd.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    int newId = Convert.ToInt32(result);
                    return newId;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

    }
}
