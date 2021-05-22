using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class ShowRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static List<Show> GetAllShows()
        {
            return (from x in db.Shows select x).ToList();
        }

        public static Show GetShowById(int id)
        {
            return db.Shows.Find(id);
        }

        public static bool AddShow(Show newShow)
        {
            if (newShow != null)
            {
                db.Shows.Add(newShow);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
