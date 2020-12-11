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

        public int? CreateNewOfficeAddress(Office office)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd;
                    if (office.StreetAddress2 != null)
                    {
                        cmd = new SqlCommand("insert into adress (streetaddress, streetaddress2, city, state, zip) values (@streetaddress, @streetaddress2, @city, @state, @zip)", conn);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into adress (streetaddress,  city, state, zip) values (@streetaddress, @city, @state, @zip)", conn);
                    }
                    cmd.Parameters.AddWithValue("@streetaddress", office.StreetAddress);
                    if (office.StreetAddress2 != null)
                    {
                        cmd.Parameters.AddWithValue("@streetaddress2", office.StreetAddress2);

                    }
                    cmd.Parameters.AddWithValue("@city", office.City);
                    cmd.Parameters.AddWithValue("@state", office.State);
                    cmd.Parameters.AddWithValue("@zip", office.Zip);

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded == 1)
                    {
                        cmd = new SqlCommand("scope_identity()", conn);
                        var addressId = cmd.ExecuteScalar();
                        return Convert.ToInt32(addressId);
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



