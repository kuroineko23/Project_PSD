using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class ReviewHandler
    {
        public static List<Review> GetReviewByShowId(int id)
        {
            return ReviewRepository.GetReviewByShowId(id);
        }

        public static double GetAverageRatingByShowId(int id)
        {
            List<Review> rev = GetReviewByShowId(id);
            List<int> Ratings = (from x in rev select x.Rating).ToList();

            return Ratings.Average();
        }
    }
}