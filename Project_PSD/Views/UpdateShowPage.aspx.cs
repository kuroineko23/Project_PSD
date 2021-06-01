using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class UpdateShowPage : System.Web.UI.Page
    {
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["TAxAidi_User"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            if(Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                this.id = id;
            }
            else
            {
                Response.Redirect("ShowDetailPage.aspx");
            }
            
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
