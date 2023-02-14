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
    public partial class WebForm5 : System.Web.UI.Page
    {
        String conStr = @"Data Source=admin-pc\sqlexpress;Initial Catalog=Database1;Integrated Security=True";
        SqlConnection con;
        SqlCommand Updcmd;
        int[] ubkd=new int[20];
        static int bktime = 0;
        Boolean t1bkst = false;
        Boolean t2bkst = false;
        Boolean t3bkst =false;
        Boolean t4bkst =false;
        Boolean t7bkst =false;
        Boolean t6bkst =false;
        Boolean t8bkst =false;
        Boolean t9bkst =false;
        Boolean t10bkst =false;
        Boolean t11bkst =false;
        int tbno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbno = 0;
                bktime = 0;
                if (Session["SName"] != null)
                {
                    Response.Write(Session["SName"].ToString());
                }
                else
                {
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    Button8.Enabled = false;
                    Button9.Enabled = false;
                    Button11.Enabled = false;
                    Button10.Enabled = false;
                }
                try
                {
                    con = new SqlConnection(conStr);
                    con.Open();
                    SqlCommand cmd;
                    SqlDataReader datareader;
                    String sqlCmd = "SELECT Tableid FROM TABLEBOOKING WHERE Tablestatus='Unbooked'";
                    cmd = new SqlCommand(sqlCmd, con);
                    datareader = cmd.ExecuteReader();
                    for (int i = 0; i < 10; i++)
                    {
                        ubkd[i] = 1;
                    }
                    while (datareader.Read())
                    {
                        ubkd[Convert.ToInt32(datareader.GetValue(0).ToString()) - 1] = 0;
                    }
                    if (ubkd[0] == 1)
                        t1bkst = true; chgColor(Button1, t1bkst);
                    if (ubkd[1] == 1)
                        t2bkst = true; chgColor(Button2, t2bkst);
                    if (ubkd[2] == 1)
                        t3bkst = true; chgColor(Button3, t3bkst);
                    if (ubkd[3] == 1)
                        t4bkst = true; chgColor(Button4, t4bkst);
                    if (ubkd[4] == 1)
                        t6bkst = true; chgColor(Button6, t6bkst);
                    if (ubkd[5] == 1)
                        t7bkst = true; chgColor(Button7, t7bkst);
                    if (ubkd[6] == 1)
                        t8bkst = true; chgColor(Button8, t8bkst);
                    if (ubkd[7] == 1)
                        t9bkst = true; chgColor(Button9, t9bkst);
                    if (ubkd[8] == 1)
                        t10bkst = true; chgColor(Button10, t10bkst);
                    if (ubkd[9] == 1)
                        t11bkst = true; chgColor(Button11, t11bkst);

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
            else
            {
                Response.Write("<H1 forecolor=\"RED\">Booked Successfully</H1>");
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
                Button11.Enabled = false;
                Button10.Enabled = false;
                con = new SqlConnection(conStr);
                con.Open();

            }
            
        }
        protected void chgColor(Button b,Boolean bks)
        {
            if (bks == true)
            {
                b.BackColor = System.Drawing.Color.Red; b.Text = "Booked";
                b.Enabled = false;
            }
            else
            {
                b.BackColor = System.Drawing.Color.Green;
                b.Text = "Unbooked";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["SName"] != null)
            {
                if (t1bkst == true)
                    t1bkst = false;
                else
                    t1bkst = true;
                chgColor(Button1, t1bkst);
                tbno = 1;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t2bkst = !t2bkst;
                chgColor(Button2, t2bkst);
                tbno = 2;
                con = new SqlConnection(conStr);
                con.Open(); 
                execUpdate(Session["SName"].ToString(), tbno);
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t3bkst = !t3bkst;
                chgColor(Button3, t3bkst);
                tbno = 3;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t4bkst = !t4bkst;
                chgColor(Button4, t4bkst);
                tbno = 4;
                con = new SqlConnection(conStr);
                con.Open(); 
                execUpdate(Session["SName"].ToString(), tbno);
                
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t6bkst = !t6bkst;
                chgColor(Button6, t6bkst);
                tbno = 5;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
                
            }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t7bkst = !t7bkst;
                chgColor(Button7, t7bkst);
                tbno = 6;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
                
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t8bkst = !t8bkst;
                chgColor(Button8, t8bkst);
                tbno = 7;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
                
            }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t9bkst = !t9bkst;
                chgColor(Button9, t9bkst);
                tbno = 8;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
                
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t10bkst = !t10bkst;
                chgColor(Button10, t10bkst);
                tbno = 9;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(), tbno);
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if (bktime == 0 && Session["SName"] != null)
            {
                t11bkst = !t11bkst;
                chgColor(Button11, t11bkst);
                tbno = 10;
                con = new SqlConnection(conStr);
                con.Open();
                execUpdate(Session["SName"].ToString(),tbno);
            }
        }
        public void execUpdate(String s, int tbn)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String cmdStr = "UPDATE REGISTRATION SET Tableno =" + tbn + "WHERE Name ='" + Session["SName"] + "'";
            Updcmd = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            cmdStr = "UPDATE TABLEBOOKING SET Tablestatus = 'Booked' WHERE Tableid =" + tbn + "";
            Updcmd = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand = new SqlCommand(cmdStr, con);
            dataAdapter.UpdateCommand.ExecuteNonQuery();
                
        }
    }
}