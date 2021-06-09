using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class HistoryController
    {
        public static List<TransactionHistory> GetTransactionHistory(int buyerId)
        {
            return HistoryHandler.GetTransactionHistory(buyerId);
        }
    }
}
