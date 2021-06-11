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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            User user = (User)Session["User"];
            if (user.RoleId != 2)
            {
                Response.Redirect("HomePage.aspx");
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["THid"]);
                this.id = id;
            }

            TransactionHeader currTH = TransactionHeaderController.getTransHeadById(id);
            if (user.Id != currTH.BuyerId)
            {
                Response.Redirect("TransactionPage.aspx");
            }

            Show currShow = ShowController.GetShowById(currTH.ShowId);

            ShowNameLbl.Text = currShow.Name;
            AverageRatingLbl.Text = ReviewController.GetAverageRatingByShowId(currShow.Id).ToString();
            DescriptionLbl.Text = currShow.Description;

            List<TransactionDetail> currTD = TransactionDetailController.getTransDetListByHeadId(currTH.Id);
            
            List<String> UsedToken = new List<string>();
            List<String> UnUsed = new List<string>();
            for(int i = 0; i < currTD.Count(); i++)
            {
                if (currTD[i].StatusId == 1)
                    UnUsed.Add(currTD[i].Token);
                else
                    UsedToken.Add(currTD[i].Token);
            }

            FillGrid(currTH.Id);
        }
        protected void FillGrid(int HeadId)
        {
            UnusedTokenGV.DataSource = TransactionDetailController.getUnUsedTokenByHeadId(HeadId);
            UnusedTokenGV.DataBind();

            UsedTokenGV.DataSource = TransactionDetailController.getUsedTokenByHeadId(HeadId);
            UsedTokenGV.DataBind();
        }
    }
}
