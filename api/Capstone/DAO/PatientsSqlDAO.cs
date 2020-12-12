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

        public string GetDoctorAvailability(Doctor doctor)
        { //datetime?
            //just a skelly 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT availability from doctor_day where doctorId = @doctorId", conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctor.UserId);
                    SqlDataReader reader = cmd.ExecuteReader();

                   
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return "1";
        }

        public string BookAppointment()
        {
            //i am just adding things at this point maybe it saves on time? 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insert into appointments ", conn);
                    cmd.Parameters.AddWithValue("", "");
                    SqlDataReader reader = cmd.ExecuteReader();


                }
            }
            catch (SqlException)
            {
                throw;
            }
            return "1";
        }
        public string ReadReviews()
        {
            return "it is 7:07 friday";
        }
        public string PostReviews()
        {
            return "post a review please";
        }
    }
}
