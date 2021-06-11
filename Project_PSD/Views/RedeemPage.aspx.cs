using Project_PSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class RedeemPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedeemBtn_Click(object sender, EventArgs e)
        {
            string token = TokenTxt.Text;

            ErrorLbl.Text = TransactionDetailController.redeemToken(token);
            if (ErrorLbl.Text == "Used")
            {
                Response.Redirect("ReviewPage.aspx");
            }
            else if(ErrorLbl.Text == "Token Invalid" || ErrorLbl.Text == "You missed the show. :(")
            {

            }
            else if(ErrorLbl.Text == "ShowTime")
            {
                Response.Redirect("./ReviewPage.aspx?token=" + token);
                Response.Redirect("ErrorLbl.Text");
            }   
        }
    }
}