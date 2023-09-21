using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
 
namespace kavineknaukri
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            if(ddlusertype.SelectedValue == "1")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbljobrecruiter where jr_email='" + txtemail.Text + "'and jr_password='" + txtpassword.Text + "' and status = 0 ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    Session["JRID"]= dt.Rows[0]["jr_id"];
                    Response.Redirect("jobrecruiter folder/Homejobrecruiter.aspx");
                    //lblmsg.Text = " --LOGIN SUCESSFULL-- ";
                }
                else
                {
                    lblmsg.Text = " --LOGIN UNSUCESSFULL-- ";
                }
            }
            else if (ddlusertype.SelectedValue == "2")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbljobseeker where js_email='"+txtemail.Text+"'and js_password='"+txtpassword.Text+"' and status = 0 ",con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if(dt.Rows.Count>0)
                {
                    Session["JSID"] = dt.Rows[0]["js_id"];
                    Response.Redirect("jobseeker folder/Homejobseeker.aspx");
                    //lblmsg.Text = " --LOGIN SUCESSFULL-- ";
                }
                else
                {
                    lblmsg.Text = " --LOGIN UNSUCESSFULL-- ";
                }



            }
            else if (ddlusertype.SelectedValue == "3")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbladmin where admin_email='" + txtemail.Text + "'and admin_password='" + txtpassword.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    Session["ADMINID"] = dt.Rows[0]["admin_id"];
                    Response.Redirect("admin folder/Homeadmin.aspx");
                    //lblmsg.Text = " --LOGIN SUCESSFULL-- ";
                }
                else
                {
                    lblmsg.Text = " --LOGIN UNSUCESSFULL-- ";
                }
            }
        }
    }
}