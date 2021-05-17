using Project_PSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null || Request.Cookies["TAxAidi_User"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string confirm = confirmTxt.Text;
            string role = RoleDD.SelectedValue;

            string result = UserController.RegistrationValidation(name, username, password, confirm, role);
            if(result == "Registration Successful!")
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
