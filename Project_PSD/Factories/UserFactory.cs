using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factories
{
    public class UserFactory
    {
        public static User create(string username, string password, string name, int roleId)
        {
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.Name = name;
            newUser.RoleId = roleId;
            return newUser;
        }
    }
}
