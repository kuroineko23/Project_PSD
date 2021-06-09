using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class HistoryHandler
    {
        public static List<TransactionHistory> GetTransactionHistory(int buyerId)
        {
            return HistoryRepository.GetTransactionHistory(buyerId);
        }
    }
}
