using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class ShowFactory
    {
        public static Show create(int sellerId, string name, int price, string description)
        {
            Show newShow = new Show();
            newShow.SellerId = sellerId;
            newShow.Name = name;
            newShow.Price = price;
            newShow.Description = description;
            return newShow;
        }
    }
}
