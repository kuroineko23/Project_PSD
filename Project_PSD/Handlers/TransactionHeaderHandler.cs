using Project_PSD.Factories;
using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class TransactionHeaderHandler
    {
        public static int InsertTransactionHeader(int buyerId, int showId, DateTime showTime)
        {
            TransactionHeader newTh = TransactionHeaderFactory.Create(buyerId, showId, showTime);

            if (TransactionHeaderRepository.InsertTHeader(newTh))
            {
                return newTh.Id;
            }
            else
            {
                return -1;
            }
        }

        //public static List<TransactionHeader> GetTransactionHeaderById(int buyerId)
        //{
        //    return TransactionHeaderRepository.GetTransactionHeadersListByBuyerId(buyerId);
        //}
        public static TransactionHeader getTransHeadById(int id)
        {
            return TransactionHeaderRepository.getTransHeadById(id);
        }
    }
}
