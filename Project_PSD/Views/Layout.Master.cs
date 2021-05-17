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
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                GuestPanel.Visible = true;
                SellerPanel.Visible = false;
                BuyerPanel.Visible = false;
                MemberPanel.Visible = false;
                UsernameLbl.Text = "Guest";
            }
            else
            {
                if(Session["User"] == null)
                {
                    Session["User"] = UserController.GetUser(int.Parse(Request.Cookies["TAxAidi_User"].Value));
                }
                User currentUser = (User)Session["User"];
                if (currentUser.RoleId == 1)
                {
                    SellerPanel.Visible = true;
                    GuestPanel.Visible = false;
                    BuyerPanel.Visible = false;
                    MemberPanel.Visible = true;
                }
                else
                {
                    BuyerPanel.Visible = true;
                    SellerPanel.Visible = false;
                    GuestPanel.Visible = false;
                    MemberPanel.Visible = true;
                }
                UsernameLbl.Text = currentUser.Name;
            }
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void RedeemBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RedeemPage.aspx");
        }

        protected void AddShowBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddShowPage.aspx");
        }

        protected void ReportBtn_Click(object sender, EventArgs e)
        {

        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Cookies["TAxAidi_User"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("LoginPage.aspx");
        }

        protected void AccountBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void TransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionPage.aspx");
        }
    }
}
