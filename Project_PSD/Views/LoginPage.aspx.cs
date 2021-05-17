using Project_PSD.Controllers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null || Request.Cookies["TAxAidi_User"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            bool remember = rememberCheck.Checked;

            string result = UserController.LoginValidation(username, password);
            if(result == "")
            {
                User user = UserController.GetUser(username, password);
                Session["User"] = user;
                if(remember)
                {
                    HttpCookie cookie = new HttpCookie("TAxAidi_User");
                    cookie.Value = user.Id.ToString();
                    cookie.Expires = DateTime.Now.AddYears(99);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
                ErrorLbl.Text = result;
            }
        }
    }
}
