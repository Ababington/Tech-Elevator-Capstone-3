using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class DoctorSqlDAO : IDoctorDAO
    {
        private readonly string connectionString;

        public DoctorSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
      

       

        public string ApproveDoctorUser (Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update users set user_role = 'doctorVerified' where user_id = @user_id; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@user_id", doctor.UserId);

                    object result = cmd.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    string newId = (string)result;
                    return newId;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Doctor GetAllDoctors(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Doctor GetmyInfo(Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from doctor where userId = @userId; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@user_id", doctor.UserId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return doctor;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Doctor UpdateMyInfo(Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update doctor set hourlyRate = @hourlyRate; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@hourlyRate", doctor.HourlyRate);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return doctor;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
