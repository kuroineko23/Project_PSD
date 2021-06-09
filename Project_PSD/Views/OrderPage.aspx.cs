using Project_PSD.Controllers;
using Project_PSD.Factories;
using Project_PSD.Handlers;
using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class OrderPage : System.Web.UI.Page
    {
        private int id, TimeId;
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

            
            DateTime selectedDate = ShowDateCalendar.SelectedDate;
            if (selectedDate.ToString() != "1/1/0001 12:00:00 AM") //defaultdate, sebelum pilih date 
            {
                FillGridAvailableTime(id, selectedDate); //fillgrid error jika date belum dipilih, maka harus ada date dlu baru jalan fillgrid
            }
            
        }

        protected void FillGridAvailableTime(int showId, DateTime date)
        {
            List<Time> Available = TimeController.GetAvailableShowTimeListAndDate(id, date);
            TimeTableGV.DataSource = Available;
            TimeTableGV.DataBind();
        }

        protected void refreshBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = ShowDateCalendar.SelectedDate;
            //ErrorLbl.Text = selectedDate.ToString();
            //FillGridAvailableTime(id, DateTime.Now);
            //ErrorLbl.Text = TimeRepository.Insert(TimeFactory.create(id, selectedDate, true)).ToString();
            //ErrorLbl.Text = TimeHandler.CreateDefault(id, selectedDate);
            //List<Time> Available = TimeController.GetAvailableShowTimeListAndDate(id, selectedDate);
            //DateTime now = DateTime.Now;
            //ErrorLbl.Text = TimeHandler.UpdateHourAvailability(id, selectedDate).ToString();
            //ErrorLbl.Text = now.ToString();
            //TimeTableGV.DataSource = Available;
            //TimeTableGV.DataBind();
            selectedDate.AddMinutes(59);
        }
        protected void Orderbtn_Click(object sender, EventArgs e)
        {
            int TimeId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            
            Time time = TimeController.GetTimeById(TimeId);

            ErrorLbl.Text = TransactionHeaderController.CheckOrder(QtyTxt.Text, time);
            if (ErrorLbl.Text != "")
                return;

            int qty = int.Parse(QtyTxt.Text);

            TimeController.TimeOrdered(TimeId);

            User user = (User)Session["User"];
            
            int transHeaderId = TransactionHeaderController.InsertTransactionHeader(user.Id, id, time.ShowTime);

            HeaderGenTxt.Visible = true;
            FillTokenGrid(transHeaderId, qty);

        }

        protected void TimeTableGV_RowDataBound(object sender, GridViewRowEventArgs e)
        { //function not found ???
            string order = e.Row.Cells[1].ToString();
            if(order == "UNAVAILABLE")
            {
                LinkButton btn = (LinkButton)e.Row.FindControl("Orderbtn");
                btn.Enabled = false;
                btn.ForeColor = System.Drawing.Color.Gray;
            }
        }

        protected void TimeTableGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void FillTokenGrid(int transHeaderId, int qty)
        {
            TokenList.DataSource = TransactionDetailController.InsertTransactionDetail(transHeaderId, qty);
            TokenList.DataBind();
        }

    }
}
