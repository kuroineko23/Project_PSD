using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int buyerId, int showId, DateTime showTime)
        {
            TransactionHeader th = new TransactionHeader();
            th.BuyerId = buyerId;
            th.ShowId = showId;
            th.ShowTime = showTime;
            th.CreatedAt = DateTime.Now;
            return th;
        }
    }
}