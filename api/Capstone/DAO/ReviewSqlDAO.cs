using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class ReviewSqlDAO :IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Review> GetMyOfficeReviews(int doctorId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select reviewId, officeId, userId, message, rating, anonymous from officeReviews join office on office.id = officeReviews.officeId where officeId = @officeId;", conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Review reviewRead = null;
                    while (reader.Read())
                    {
                       // doctorRead = GetDoctorFromReader(reader);
                    }
                    throw new NotImplementedException();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Review GetOfficeReviews(int officeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select reviewId, officeId, userId, message, rating, anonymous from officeReviews join office on office.id = officeReviews.officeId where officeId = @officeId;", conn);
                    cmd.Parameters.AddWithValue("@officeId", officeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Review reviewRead = null;
                    while (reader.Read())
                    {
                         reviewRead = GetReviewFromReader(reader);
                    }
                    throw new NotImplementedException();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public bool PostNewReview()
        {
            throw new NotImplementedException();
        }


        private Review GetReviewFromReader(SqlDataReader reader)
        {
            Review reviewRead = new Review()
            {
                ReviewId = Convert.ToInt32(reader["reviewId"]),
                OfficeId = Convert.ToInt32(reader["officeId"]),
                UserId = Convert.ToInt32(reader["userId"]),
                Message = Convert.ToString(reader["message"]),
                Rating = Convert.ToInt32(reader["rating"]),
                Anonymous = Convert.ToBoolean(reader["anonymous"])


            };
            return reviewRead;
        }
    }
}
