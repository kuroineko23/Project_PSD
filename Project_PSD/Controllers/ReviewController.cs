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
        public static List<Review> GetReviewByShowId(int showId)
        {
            return ReviewHandler.GetReviewByShowId(showId);
        }
        public static double GetAverageRatingByShowId(int id)
        {
            return ReviewHandler.GetAverageRatingByShowId(id);
        }
        public static bool AlreadyReviewByDetailId(int TDid)
        {
            return ReviewHandler.AlreadyReviewByDetailId(TDid);
        }
        public static string Validate(string rating, string description)
        {
            string response = "";
            if (rating == "")
            {
                response = "Rating must be numeric and ";
            }
            else if (int.Parse(rating) < 1)
            {
                response = "Rating must be at least 1 and at most 5";
            }
            else if (description == "")
            {
                response = "Description must be filled";
            }
            return response;
        }
        public static string ValidateAndRate(string rating, string description, int TDid)
        {
            string response = Validate(rating, description);

            if (response != "")
            {
                return response;
            }
            int currRate = int.Parse(rating);

            if (ReviewHandler.Rate(currRate, description, TDid))
            {
                response = "";
            }
            else
            {
                response = "Failed to Rate the show";
            }
            return response;
        }
        public static string ValidateAndUpdate(string rating, string description, int TDid)
        {
            string response = Validate(rating, description);

            if (response != "")
            {
                return response;
            }
            int currRate = int.Parse(rating);

            if (ReviewHandler.Update(currRate, description, TDid))
            {
                response = "";
            }
            else
            {
                response = "Failed to Update Review";
            }
            return response;
        }
        public static string Delete(int TDetId)
        {
            string response = "";

            if (ReviewHandler.Delete(TDetId))
            {
                response = "";
            }
            else
            {
                response = "Review not found!";
            }

            return response;
        }
    }
}