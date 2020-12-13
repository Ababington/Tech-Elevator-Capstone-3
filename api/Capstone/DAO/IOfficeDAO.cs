using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IOfficeDAO
    {
        int CreateNewOffice(Office office);
        List<Office> GetMyOffices(int doctorId);
        List<Office> GetAllOffices();




        /*
        List<Office> GetMyOfficeReviews(int doctorId); //TODO change return datatype when adding Review class, move to reviewDAO

        List<Office> GetReviewResponses(int doctorId); //TODO change return datatype when adding Response class, move to responseDAO(maybe just reviewsDAO???)

        Office GetOfficeReviews(int officeId); //TODO change return datatype when adding Review class, move to reviewDAO

        bool PostNewReview(Add Review Datatype); //TODO move to reviewDAO
        */

    }
}
