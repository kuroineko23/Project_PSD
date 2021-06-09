using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class TransactionHeaderController
    {
        public static int InsertTransactionHeader(int buyerId, int showId, DateTime showTime)
        {
            return TransactionHeaderHandler.InsertTransactionHeader(buyerId, showId, showTime);
        }

        public static string CheckOrder(string qty, Time time)
        {
            string response = "";
            if(qty == "" )
            {
                response = "Quantity must be numeric and at least 1";
            }
            else if (int.Parse(qty) < 1)
            {
                response = "Quantity must be numeric and at least 1";
            }
            else if (time.Availablity == false)
            {
                response = "Time choosen Unavailable";
            }
            return response;
        }
    }
}
