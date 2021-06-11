using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class ReviewRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static List<Review> GetReviewByShowId(int id)
        {
            List<int> trxHeaderId = (from x in db.TransactionHeaders where x.ShowId.Equals(id) select x.Id).ToList();
            List<int> trxDetailId = (from x in db.TransactionDetails where x.TransactionHeaderId.Equals(trxHeaderId) select x.Id).ToList();
            return (from x in db.Reviews where x.TransactionDetailId.Equals(trxDetailId) select x).ToList();   
        }
        public static List<Review> GetReviewListByTDetId(int TDetId)
        {
            return (from x in db.Reviews where x.TransactionDetailId == TDetId select x).ToList();
        }

        public static List<int> GetRatingListByShowId(int id)
        {
            List<Review> rev = GetReviewByShowId(id);
            return (from x in rev select x.Rating).ToList();
        }
        public static bool AlreadyReviewByDetailId(int TDid)
        {
            return ((from x in db.Reviews where x.TransactionDetailId == TDid select x).Count() != 0);
        }
        public static bool Insert(Review r)
        {
            if (r != null)
            {
                db.Reviews.Add(r);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static Review GetReviewByTransDetId(int TDetId)
        {
            return (from x in db.Reviews where x.TransactionDetailId.Equals(TDetId) select x).FirstOrDefault();
        }
        public static bool Update(Review r)
        {
            if (r != null)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(Review r)
        {
            if (r != null)
            {
                db.Reviews.Remove(r);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
