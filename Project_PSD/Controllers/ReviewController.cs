using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class ReviewController
    {
        public static List<Review> GetReviewByShowId(int id)
        {
            return ReviewHandler.GetReviewByShowId(id);
        }
        public static double GetAverageRatingByShowId(int id)
        {
            return ReviewHandler.GetAverageRatingByShowId(id);
        }
    }
}