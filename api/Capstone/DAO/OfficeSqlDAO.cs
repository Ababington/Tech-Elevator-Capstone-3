using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class OfficeSqlDAO :IOfficeDAO
    {
        private readonly string connectionString;

        public OfficeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public int? CreateNewOffice(Office office)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into office (phone, name) values (@phone, @name)", conn);
                    cmd.Parameters.AddWithValue("@phone", office.Phone );
                    cmd.Parameters.AddWithValue("@name", office.Name);

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded == 1)
                    {
                        cmd = new SqlCommand("scope_identity()", conn);
                        var officeId = cmd.ExecuteScalar();
                        return Convert.ToInt32(officeId);
                    }
                    else
                    { 
                        return null;
                    }
                  

                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

    }
}
