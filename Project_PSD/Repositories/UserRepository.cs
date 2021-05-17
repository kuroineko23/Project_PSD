using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repositories
{
    public class UserRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static bool insertUser(User newUser)
        {
            if(newUser != null)
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static User findUser(string username, string password)
        {
            return (from x in db.Users where x.Username == username && x.Password == password select x).FirstOrDefault();
        }

        public static User findUser(int id)
        {
            return (from x in db.Users where x.Id == id select x).FirstOrDefault();
        }
    }
}
