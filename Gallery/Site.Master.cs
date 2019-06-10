using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gallery
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_MainPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void LinkButton_CarsPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cars.aspx");
        }

        protected void LinkButton_AnimalsPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Animals.aspx");
        }

        protected void LinkButton_MotorcyclePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Motorcycles.aspx");
        }
    }
}