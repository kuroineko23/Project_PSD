using Project_PSD.Factories;
using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handler
{
    public class ShowHandler
    {
        public static List<Show> GetShowList()
        {
            return ShowRepository.GetAllShows();
        }

        public static bool AddShow(int sellerId, string name, int price, string description)
        {
            Show newShow = ShowFactory.create(sellerId, name, price, description);
            return ShowRepository.AddShow(newShow);
        }
    }
}
