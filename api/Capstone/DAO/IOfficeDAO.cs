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


        //new additions from doctor controller
        Office GetMyOffices(Office office);
        Office GetMyOfficeReviews(Office office);
        Office GetReviewResponses(Office office);


        //from patient controller
        Office GetAllOffices(Office office);
        Office GetOfficeReviews(Office office);
        Office PostNewReview(Office office);


    }
}
