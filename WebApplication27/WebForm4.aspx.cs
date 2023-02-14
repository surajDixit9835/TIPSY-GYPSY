using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication27
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SName"] != null)
                Label1.Text = Session["SName"].ToString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.facebook.com/officialtipsygypsy/");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("mailto:sayhello@gipsyhospitality.com");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.instagram.com/tipsygypsyofficial");
        }
    }
}