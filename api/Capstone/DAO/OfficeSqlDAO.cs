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
                    cmd.Parameters.AddWithValue("@phone", office.Phone);
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

        public Office GetAllOffices(Office office)
        {
            throw new NotImplementedException();
        }

        public Office GetMyOfficeReviews(Office office)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from officeReviews where officeId = @officeId; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@user_id", office.OfficeId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return office;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Office GetMyOffices(Office office)
        {
            //doctor object??
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from office where id = @id; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@id", office.OfficeId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return office;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Office GetOfficeReviews(Office office)
        {
            throw new NotImplementedException();
        }

        public Office GetReviewResponses(Office office)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from reviewResponse where userId = @userId; select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@userId", office.OfficeId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return office;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Office PostNewReview(Office office)
        {
            throw new NotImplementedException();
        }
    }
}
