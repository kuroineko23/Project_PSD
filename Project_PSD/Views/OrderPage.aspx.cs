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
    public partial class OrderPage : System.Web.UI.Page
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
                int id = int.Parse(Request.QueryString["id"]);
                this.id = id;
            }

            Show show = ShowController.GetShowById(id);

            ShowNameLbl.Text = show.Name;
            ShowPriceLbl.Text = show.Price.ToString();

            User seller = UserController.GetUser(show.SellerId);
            SellerNameLbl.Text = seller.Name;
            DescriptionLbl.Text = show.Description;

            //AverageRatingLbl.Text = ReviewController.GetAverageRatingByShowId(id).ToString();

        }
    }
}
