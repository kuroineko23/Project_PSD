using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class TransactionHeaderRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static bool InsertTHeader(TransactionHeader newTh)
        {
            if (newTh != null)
            {
                db.TransactionHeaders.Add(newTh);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<TransactionHeader> GetTransactionHeadersList()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        //public static List<TransactionHeader> GetTransactionHeadersListById(int buyerId)
        //{
        //    return (from x in db.TransactionHeaders where x.BuyerId == buyerId select x).ToList();
        //}
        public static TransactionHeader getTransHeadById(int id)
        {
            return (from x in db.TransactionHeaders where x.Id == id select x).FirstOrDefault(); 
        }
        public static List<TransactionHeader> getTransHeadByShowId(int ShowId)
        {
            return (from x in db.TransactionHeaders where x.ShowId == ShowId select x).ToList();
        }
    }
}
