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
    public partial class AddShowPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = null;
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            user = (User)Session["User"];
            if(user.RoleId != 1)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            int price = int.Parse(PriceTxt.Text);
            string description = DescriptionTxt.Text;
            User user = (User)Session["User"];

            string result = ShowController.AddShowValidation(user.Id, name, price, description);
            if(result == "Add show success!")
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            ErrorLbl.Text = result;
        }
    }
}
