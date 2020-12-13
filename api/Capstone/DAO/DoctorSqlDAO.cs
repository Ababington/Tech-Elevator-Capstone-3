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
      

        public int ApproveDoctorUser (Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update users set user_role = 'doctorVerified' where user_id = @user_id;", conn);
                    cmd.Parameters.AddWithValue("@user_id", doctor.UserId);

                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> verifiedDoctorList = new List<Doctor>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select userId, hourlyRate, firstName, lastName from doctor join users on users.user_id = doctor.userId where user_role = 'doctorVerified';", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Doctor doctorRead = GetDoctorFromReader(reader);
                        verifiedDoctorList.Add(doctorRead);
                    }
                    return verifiedDoctorList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Doctor GetmyInfo(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select userId, hourlyRate, firstName, lastName from doctor join users on users.user_id = doctor.userId where user_id = @userId;", conn);
                    cmd.Parameters.AddWithValue("@userId", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Doctor doctorRead = null;
                    while (reader.Read())
                    {
                        doctorRead = GetDoctorFromReader(reader);
                    }
                    return doctorRead;
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
                    SqlCommand cmd = new SqlCommand("update doctor set hourlyRate = @hourlyRate, firstName = @firstName, lastName=@lastName;", conn);
                    cmd.Parameters.AddWithValue("@hourlyRate", doctor.HourlyRate);
                    cmd.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", doctor.LastName);
                    SqlDataReader reader = cmd.ExecuteReader();

                    //TODO DO WE NEED TO TALK TO DOCTOR/DAY TBL HERE AS WELL??????

                    return doctor;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        private Doctor GetDoctorFromReader(SqlDataReader reader)
        {
            Doctor doctorRead = new Doctor()
            {
                UserId = Convert.ToInt32(reader["userId"]),
                HourlyRate = Convert.ToDecimal(reader["hourlyRate"]),
                FirstName = Convert.ToString(reader["firstName"]),
                LastName = Convert.ToString(reader["lastName"])
            };
            return doctorRead;
        }
    }
}
