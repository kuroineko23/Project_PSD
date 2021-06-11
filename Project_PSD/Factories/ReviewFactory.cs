using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class ReviewFactory
    {
        public static Review Create(int rate, string desc, int TDetId)
        {
            Review newRev = new Review();
            newRev.TransactionDetailId = TDetId;
            newRev.Rating = rate;
            newRev.Description = desc;
            return newRev;
        }
    }
}