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

        public static List<int> GetRatingListByShowId(int id)
        {
            List<Review> rev = GetReviewByShowId(id);
            return (from x in rev select x.Rating).ToList();
        }
    }
}