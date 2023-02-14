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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String conStr = @"Data Source=admin-pc\sqlexpress;Initial Catalog=Database1;Integrated Security=True";
                SqlConnection con;
                con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                String cmdStr = "INSERT INTO ADMIN(Name,Time) VALUES ('" + Session["AdminName"].ToString() + "','" + DateTime.UtcNow.ToString() + "')";
                cmd = new SqlCommand(cmdStr, con);
                dataAdapter.InsertCommand = new SqlCommand(cmdStr, con);
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String conStr = @"Data Source=admin-pc\sqlexpress;Initial Catalog=Database1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand Updcmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            GridViewRow row = GridView2.Rows[e.RowIndex];
            String cmdStr = "UPDATE TABLEBOOKING SET Tablestatus = 'Unbooked' WHERE Tableid =" + Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Values["Tableid"].ToString()) + "";
            Updcmd = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand.ExecuteNonQuery(); GridView2.DataBind();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}