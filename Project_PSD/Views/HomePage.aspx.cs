using Project_PSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        protected void FillGrid()
        {
            ShowGV.DataSource = ShowController.GetShowList();
            ShowGV.DataBind();
        }

        protected void DetailLink_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("./ShowDetailPage.aspx?id=" + id);
        }
    }
}
