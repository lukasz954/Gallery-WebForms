using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gallery
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Anuimals_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Animals.aspx");
        }

        protected void Cars_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Cars.aspx");
        }

        protected void Motorcycles_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Motorcycles.aspx");
        }
    }
}