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
        //do we want a method to add to office info? Off of trello doctor should update and add info but what could they add? 
        public int GetOfficeHours(int id)
        {
            //work on mostly skeleton check select statement 
            Office office = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from doctor_day where id = @id ", conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return 1;
                }

            }
            catch (SqlException e)
            {
                throw e;
            }

        }

        public int UpdateDoctorAvailability(Doctor doctor)
        {//skeleton probably maybe i did it right? haha probably not
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update doctor_day set availability where doctorId = @doctorId", conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctor.UserId);

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


        public decimal UpdateDoctorRates(Doctor doctor)
        {
            //not finished skeleton
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update doctor set hourlyRate where userId = @userId", conn);
                    cmd.Parameters.AddWithValue("@userId", doctor.HourlyRate);

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
        public string GetMyDoctorAppointments()
        {
            return "welp";
        }
        public string SeeReviewRespond()
        {
            return "";
        }
    }
}
