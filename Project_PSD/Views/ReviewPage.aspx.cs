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
    public partial class ReviewPage : System.Web.UI.Page
    {
        private string token;
        int TDetId = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (Request.QueryString["token"] != null)
            {
                string token = Request.QueryString["token"];
                this.token = token;
            }
            else
            {
                ErrorLbl.Text = "Token Invalid";
                return;
            }

            TransactionDetail currTD = TransactionDetailController.GetTransactionDetailByToken(token);
            TDetId = currTD.Id;

            if (ReviewController.AlreadyReviewByDetailId(TDetId))
            {
                RateBtn.Visible = false;
                DeleteBtn.Visible = true;
                UpdateBtn.Visible = true;
            }
            else
            {
                RateBtn.Visible = true;
                DeleteBtn.Visible = false;
                UpdateBtn.Visible = false;
            }

            TransactionHeader currTH =  TransactionHeaderController.getTransHeadById(currTD.TransactionHeaderId);
            Show show = ShowController.GetShowById(currTH.ShowId);
            User seller = UserController.GetUser(show.SellerId);

            ShowNameLbl.Text = show.Name;
            SellerNameLbl.Text = seller.Name;
            DescriptionLbl.Text = show.Description;

        }

        protected void RateBtn_Click(object sender, EventArgs e)
        {
            string response = ReviewController.ValidateAndRate(RatingTxt.Text, DescriptionTxt.Text, TDetId);
            if (response == "")
            {
                ErrorLbl.Text = "Rate Success";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ErrorLbl.Text = response;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            string response = ReviewController.ValidateAndUpdate(RatingTxt.Text, DescriptionTxt.Text, TDetId);
            if (response == "")
            {
                ErrorLbl.Text = "Update Success";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ErrorLbl.Text = response;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string response = ReviewController.Delete(TDetId);
            if (response == "")
            {
                ErrorLbl.Text = "Review Deleted";
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ErrorLbl.Text = response;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
