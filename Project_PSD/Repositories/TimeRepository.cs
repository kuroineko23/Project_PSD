using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class TimeRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static List<Time> GetShowTimeListByShowId(int showId)
        {
            return (from x in db.Times where x.ShowId.Equals(showId) select x).ToList();
        }

        public static bool Insert(Time t)
        {
            if (t != null)
            {
                db.Times.Add(t);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static Time GetTimeById(int id)
        {
            return db.Times.Find(id);
        }

        public static bool UpdateTime(Time t)
        {
            if (t != null)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}