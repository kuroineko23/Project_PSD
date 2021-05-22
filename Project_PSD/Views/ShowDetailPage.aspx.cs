using Project_PSD.Handler;
using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class ShowDetailPage : System.Web.UI.Page
    {
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            OrderBtn.Visible = false;
            UpdateBtn.Visible = false;

            User currUser = (User)Session["user"];
            if (currUser.RoleId == 2) //seller 1 member 2 guest 3
            {
                OrderBtn.Visible = true;
            }
            else if (currUser.RoleId == 1) //seller 1 member 2 guest 3// BELUM KELAR REQUIEREMENT JIKA SHOW SOLD JUGA.
            {
                UpdateBtn.Visible = true;
            }


            int id = int.Parse(Request.QueryString["id"]);
            this.id = id;
            Show show = ShowHandler.GetShowById(id);

            ShowNameLbl.Text = show.Name;
            ShowPriceLbl.Text = show.Price.ToString();

            User seller = UserHandler.findUser(show.SellerId);
            SellerNameLbl.Text = seller.Name;
            DescriptionLbl.Text = show.Description;

            AverageRatingLbl.Text = ReviewHandler.GetAverageRatingByShowId(id).ToString();

            FillGrid();
        }
        protected void FillGrid()
        {
            ReviewGV.DataSource = ReviewHandler.GetReviewByShowId(id);
            ReviewGV.DataBind();
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderPage.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("./UpdateShowPage.aspx?id=" + id);
        }
    }
}
