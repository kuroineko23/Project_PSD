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
    public partial class ProfilePage : System.Web.UI.Page
    {

        private User currUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            currUser = (User)Session["User"];

            NameTxt.Attributes["placeholder"] = currUser.Name;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            string result = UserController.UpdateProfile(currUser, NameTxt.Text, OldPasswordTxt.Text, NewPasswordTxt.Text, ConfirmPasswordTxt.Text);
            if (result == "Profile Updated!")
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                Session["User"] = null;
            }
            else
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            ErrorLbl.Text = result;
        }
    }
}
