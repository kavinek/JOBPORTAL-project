using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace kavineknaukri.admin_folder
{
    public partial class Homeadmin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                bindadmin();
            }
        }
            public void bindadmin()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbladmin where admin_id='" + Session["ADMINID"] + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                lblname.Text = dt.Rows[0]["admin_name"].ToString();
                lblgender.Text = dt.Rows[0]["admin_gender"].ToString() == "1" ? "MALE" : dt.Rows[0]["admin_gender"].ToString() == "2" ? "FEMALE" : "OTHERS";
                lblemail.Text = dt.Rows[0]["admin_email"].ToString();
                lblpassword.Text = dt.Rows[0]["admin_password"].ToString();
        }
                             
    }
}