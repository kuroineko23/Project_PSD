using Project_PSD.Factories;
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
        public static List<Review> GetReviewByShowId(int showId)
        {
            List<TransactionHeader> currTH = TransactionHeaderRepository.getTransHeadByShowId(showId);
            List<TransactionDetail> currTD = new List<TransactionDetail>();
            
            for(int i = 0; i < currTH.Count(); i++)
            {
                currTD.AddRange(TransactionDetailRepository.getTransDetListByHeadId(currTH[i].Id));
            }

            List<Review> currRev = new List<Review>();

            for (int i = 0; i < currTD.Count(); i++)
            {
                currRev.AddRange(ReviewRepository.GetReviewListByTDetId(currTD[i].Id));
            }

            return currRev;
        }

        public static double GetAverageRatingByShowId(int showId)
        {
            List<Review> rev = GetReviewByShowId(showId);
            List<int> Ratings = (from x in rev select x.Rating).ToList();
            
            return Ratings.Average();
        }
        public static bool AlreadyReviewByDetailId(int TDid)
        {
            return ReviewRepository.AlreadyReviewByDetailId(TDid);
        }
        public static bool Rate(int rating, string desc, int TDetId)
        {
            Review r = ReviewFactory.Create(rating, desc, TDetId);

            return ReviewRepository.Insert(r);
        }
        public static bool Update(int rating, string desc, int TDetId)
        {
            Review r = ReviewRepository.GetReviewByTransDetId(TDetId);
            if (r != null)
            {
                r.Rating = rating;
                r.Description = desc;
                return ReviewRepository.Update(r);
            }
            return false;
        }
        public static bool Delete(int TDetId)
        {
            Review r = ReviewRepository.GetReviewByTransDetId(TDetId);

            return ReviewRepository.Delete(r);
        }
    }
}