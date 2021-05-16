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
    }
}