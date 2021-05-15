using Project_PSD.Factories;
using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handlers
{
    public class UserHandler
    {
        private static int GetRoleId(string role)
        {
            if(role == "seller")
            {
                return 1;
            }
            return 2;
        }
        public static bool Register(string username, string password, string name, string role)
        {
            User newUser = UserFactory.create(username, password, name, GetRoleId(role));
            return UserRepository.insertUser(newUser);
        }
    }
}
