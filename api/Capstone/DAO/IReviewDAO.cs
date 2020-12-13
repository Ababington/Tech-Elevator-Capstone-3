﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IReviewDAO
    {

        List<Review> GetMyOfficeReviews(int doctorId); //TODO change return datatype when adding Review class, move to reviewDAO


        Review GetOfficeReviews(int officeId); //TODO change return datatype when adding Review class, move to reviewDAO

        bool PostNewReview(); //TODO move to reviewDAO            Add Review Datatype


       // List<Office> GetReviewResponses(int doctorId); //TODO change return datatype when adding Response class, move to responseDAO(maybe just reviewsDAO???)

    }
}
