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
    public partial class managejobseeker : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindjobseeker();
            }
        }

        public void bindjobseeker()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("jobseeker_join ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobseeker.DataSource = dt;
            gvjobseeker.DataBind();
        }

        protected void gvjobseeker_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "B")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("jobseeker_statuschange", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@js_id", e.CommandArgument);
                cmd.ExecuteNonQuery();
                con.Close();
                bindjobseeker();
            }

            else if (e.CommandName == "R")
            {
                Response.Redirect("../jobseeker folder\\JOBSEEKERRESUME\\" + e.CommandArgument);
            }
        }
    }
}