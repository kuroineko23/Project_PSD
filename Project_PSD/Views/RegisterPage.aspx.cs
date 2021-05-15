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

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string confirm = confirmTxt.Text;
            string role = RoleDD.SelectedValue;

            string result = UserController.RegistrationValidation(name, username, password, confirm, role);
            ErrorLbl.Text = result;
        }
    }
}
