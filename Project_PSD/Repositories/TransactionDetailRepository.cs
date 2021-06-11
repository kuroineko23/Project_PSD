using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class TransactionDetailRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static bool InsertTransactDetail(TransactionDetail newTd)
        {
            if (newTd != null)
            {
                //Console.WriteLine(newTd.Token);
                db.TransactionDetails.Add(newTd);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkTokenUnique(string token)
        {
            return ((from x in db.TransactionDetails where x.Token == token select x.Token).ToList().Count() == 0);
        }
        public static List<TransactionDetail> getTransDetListByHeadId(int HeadId)
        {
            return (from x in db.TransactionDetails where x.TransactionHeaderId == HeadId select x).ToList();
        }
        public static TransactionDetail GetTransactionDetailByToken(string token)
        {
            return (from x in db.TransactionDetails where x.Token == token select x).FirstOrDefault();
        }
        public static bool UpdateStatus(TransactionDetail TD)
        {
            if (TD != null)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}