using Project_PSD.Controllers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Project_PSD.Views
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        private User currUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            currUser = (User)Session["User"];
            if (currUser.RoleId != 2)
            {
                Response.Redirect("HomePage.aspx");
            }
            FillGrid();
        }

        protected void FillGrid()
        {
            TransactionGV.DataSource = HistoryController.GetTransactionHistory(currUser.Id);
            TransactionGV.DataBind();
        }

        //protected void DetailLink_Click(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
        //    Response.Redirect("./TransactionDetailPage.aspx?THid=" + id);
        //}

        protected void DetailsLinkBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void DetailLinkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
