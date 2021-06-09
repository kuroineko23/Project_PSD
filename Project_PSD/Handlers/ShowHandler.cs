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

        public static Show GetShowById(int id)
        {
            return ShowRepository.GetShowById(id);
        }

        public static bool AddShow(int sellerId, string name, int price, string description, string url)
        {
            Show newShow = ShowFactory.create(sellerId, name, price, description, url);
            return ShowRepository.AddShow(newShow);
        }

        public static bool UpdateShow(int showId, string name, int price, string description)
        {

            Show curr = ShowRepository.GetShowById(showId);
            if (curr != null)
            {
                curr.Name = name;
                curr.Price = price;
                curr.Description = description;
                return ShowRepository.UpdateShow(curr);
            }
            return false;
        }
    }
}
