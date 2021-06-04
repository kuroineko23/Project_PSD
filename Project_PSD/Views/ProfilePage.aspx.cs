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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            User currUser = (User)Session["User"];

            NameTxt.Text = currUser.Name;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
