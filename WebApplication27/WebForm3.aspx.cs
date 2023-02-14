using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication27
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Admin")
            {
                MultiView1.ActiveViewIndex = 1;
            }
            else
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String conStr = @"Data Source=admin-pc\sqlexpress;Initial Catalog=Database1;Integrated Security=True";
                SqlConnection con;
                con = new SqlConnection(conStr);
                con.Open();
                Response.Write("SQL opened");
                String name = TextBox5.Text;
                int age = Convert.ToInt32(TextBox6.Text);
                int contactno = Convert.ToInt32(TextBox7.Text);
                String email = TextBox8.Text;
                SqlCommand cmd;
                SqlDataAdapter dataAdapter=new SqlDataAdapter();
                String cmdStr = "INSERT INTO REGISTRATION(Name,Age,Contactno,Email) VALUES ('"+name+"',"+age+","+contactno+",'"+email+"')";
                cmd = new SqlCommand(cmdStr, con);
                dataAdapter.InsertCommand = new SqlCommand(cmdStr, con);
                dataAdapter.InsertCommand.ExecuteNonQuery();
                Response.Write("Data Entered Successfully");
                Session["SName"] = TextBox5.Text;
                Session["SContact"] = TextBox7.Text;
                Response.Redirect("~/WebForm1.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("databaase Error"+ex.Message);
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Mahesh" || TextBox1.Text == "Gopi" || TextBox1.Text == "Vishal" || TextBox1.Text == "Vinnet" || TextBox1.Text == "Sai" || TextBox1.Text == "Narendra" || TextBox1.Text == "Suraj")
            {
                if (TextBox2.Text == TextBox1.Text + "123")
                {
                    Session["AdminName"] = TextBox1.Text;
                    Response.Redirect("~/WebForm7.aspx");
                }
            }

        }
    }
}