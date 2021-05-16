using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using Project_PSD.Handlers;
using Project_PSD.Models;

namespace Project_PSD.Controllers
{
    public class UserController
    {
        public static string RegistrationValidation(string name, string username, string password, string confirm, string role)
        {
            if(NameCheck(name) != "")
            {
                return NameCheck(name);
            }
            if(UsernameCheck(username) != "")
            {
                return UsernameCheck(username);
            }
            if(PasswordCheck(password, confirm) != "")
            {
                return PasswordCheck(password, confirm);
            }
            if(RoleCheck(role) != "")
            {
                return RoleCheck(role);
            }
            if(UserHandler.Register(username, password, name, role))
            {
                return "Registration Successful!";
            }
            else
            {
                return "Error registering!";
            }
        }

        public static string NameCheck(string name)
        {
            //regex : https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions
            string regexPattern = "^[a-zA-Z ]+$";
            if(name == "")
            {
                return "Name is empty!";
            }
            else if(name.Length > 30)
            {
                return "Name length must be between 1-30 characters!";
            }
            else if(!Regex.IsMatch(name, regexPattern))
            {
                return "Name contains invalid character(s)! (Alphabet and space only)";
            }
            return "";
        }

        public static string UsernameCheck(string username)
        {
            string regexPattern = "^[a-zA-Z0-9 _]+$";
            if(username == "")
            {
                return "Username is empty!";
            }
            else if(username.Length > 20 || username.Length < 6)
            {
                return "Username length must be between 6-20 characters!";
            }
            else if(!Regex.IsMatch(username, regexPattern))
            {
                return "Username contains invalid character(s)! (Alphanumeric, spaces, and underscores only)";
            }
            return "";
        }

        public static string PasswordCheck(string password, string confirm)
        {
            string regexPattern = "^[a-zA-Z0-9]+$";
            if (password.Length < 6)
            {
                return "Password length must be 6 or more characters!";
            }
            else if(!Regex.IsMatch(password, regexPattern))
            {
                return "Password contains invalid character(s)! (Alphanumeric only)";
            }
            else if(!password.Equals(confirm))
            {
                return "Confirm password does not match!";
            }
            return "";
        }

        public static string PasswordCheck(string password)
        {
            string regexPattern = "^[a-zA-Z0-9]+$";
            if (password.Length < 6)
            {
                return "Password length must be 6 or more characters!";
            }
            else if (!Regex.IsMatch(password, regexPattern))
            {
                return "Password contains invalid character(s)! (Alphanumeric only)";
            }
            return "";
        }

        public static string RoleCheck(string role)
        {
            if(role == "")
            {
                return "You must choose a role!";
            }
            return "";
        }

        public static string LoginValidation(string username, string password)
        {
            if (UsernameCheck(username) != "")
            {
                return UsernameCheck(username);
            }
            if (PasswordCheck(password) != "")
            {
                return PasswordCheck(password);
            }

            User user = UserHandler.findUser(username, password);
            if (user != null)
            {
                return "";
            }
            else
            {
                return "User not found!";
            }
        }

        public static User GetUser(string username, string password)
        {
            return UserHandler.findUser(username, password);
        }
    }
}
