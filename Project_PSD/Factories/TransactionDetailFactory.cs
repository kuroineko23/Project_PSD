using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int transactId, string token)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionHeaderId = transactId;
            td.StatusId = 1;
            td.Token = token;
            return td;
        }
    }
}