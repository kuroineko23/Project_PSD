using Project_PSD.Controllers;
using Project_PSD.Models;
using Project_PSD.Repositories;
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

            FillGrid();
        }

        protected void FillGrid()
        {
            //Items item = new Items();
            //item = 
            //TransactionHeaderController.
            /*DatabaseEntities db = new DatabaseEntities();
            List<TransactionHeader> THeaderList = new List<TransactionHeader>();
            List<TransactionDetail> TDetailList = new List<TransactionDetail>();

            THeaderList = (from x in db.TransactionHeaders 
                           join det on db.TransactionDetails equals det into de
                           from det in de.DefaultEmpty()
                           where det.TransactionHeaderId == x.Id
                           select x).ToList();

            TransactionGV.DataSource = TransactionHeaderRepository.GetTransactionHeadersList();
            TransactionGV.DataBind();
            */
            TransactionGV.DataSource = HistoryController.GetTransactionHistory(currUser.Id);
            TransactionGV.DataBind();

        }

        protected void TransactionGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void TransactionGV_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
    }
}
