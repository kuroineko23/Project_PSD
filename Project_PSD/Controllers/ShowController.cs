using Project_PSD.Handler;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class ShowController
    {
        public static string AddShowValidation(int sellerId,string name, int price, string description, string url)
        {
            if (NameCheck(name) != "")
            {
                return NameCheck(name);
            }
            if (DescriptionCheck(description) != "")
            {
                return DescriptionCheck(description);
            }
            if (PriceCheck(price) != "")
            {
                return PriceCheck(price);
            }
            if(ShowHandler.AddShow(sellerId, name, price, description, url))
            {
                return "Add show success!";
            }
            else
            {
                return "Failed to add new show!";
            }
        }

        public static string NameCheck(string name)
        {
            if (name == "")
            {
                return "Show name is empty!";
            }
            //check unique
            /*
             * code here
             * 
             */
            return "";
        }

        public static string DescriptionCheck(string description)
        {
            if (description == "")
            {
                return "Show description is empty!";
            }            
            return "";
        }

        public static string PriceCheck(int price)
        {
            if (price == 0)
            {
                return "Show price is empty!";
            }
            if(price < 1000)
            {
                return "Show price must be at least 1000";
            }
            return "";
        }
        public static string UpdateShowValidation(int showId, string name, int price, string description)
        {
            if (NameCheck(name) != "")
            {
                return NameCheck(name);
            }
            if (DescriptionCheck(description) != "")
            {
                return DescriptionCheck(description);
            }
            if (PriceCheck(price) != "")
            {
                return PriceCheck(price);
            }
            if (ShowHandler.UpdateShow(showId, name, price, description))
            {
                return "Update show success!";
            }
            else
            {
                return "Failed to update show!";
            }
        }
        public static List<Show> GetShowList()
        {
            return ShowHandler.GetShowList();
        }
        public static Show GetShowById(int id)
        {
            return ShowHandler.GetShowById(id);
        }
    }
}
