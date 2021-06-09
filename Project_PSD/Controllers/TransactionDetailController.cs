using Project_PSD.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class TransactionDetailController
    {
        public static List<String> InsertTransactionDetail(int transactId, int qty)
        {
            return TransactionDetailHandler.InsertTransactionDetail(transactId, qty);
        }
    }
}