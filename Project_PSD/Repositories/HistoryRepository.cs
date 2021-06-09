using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class HistoryRepository
    {

        private static DatabaseEntities db = new DatabaseEntities();

        public static List<TransactionHistory> GetTransactionHistory(int userId)
        {
            var History =  (from x in db.TransactionHeaders
                    join y in db.Shows on x.ShowId equals y.Id
                    select new { Id = x.Id, PaymentDate = x.CreatedAt, ShowName = y.Name, ShowTime = x.ShowTime, Price = y.Price}).ToList();
            var tHist = new List<TransactionHistory>();
            foreach (var item in History)
            {
                int quantity = (from x in db.TransactionHeaders
                                join z in db.TransactionDetails on x.Id equals z.TransactionHeaderId
                                where x.Id == item.Id
                                select new { Id = x.Id }).Count();
                TransactionHistory newTHist = new TransactionHistory();
                newTHist.PaymentDate = item.PaymentDate;
                newTHist.ShowName = item.ShowName;
                newTHist.ShowTime = item.ShowTime;
                newTHist.Quantity = quantity;
                newTHist.TotalPrice = quantity * item.Price;
                tHist.Add(newTHist);
            }

            return tHist;
        }
    }
}
