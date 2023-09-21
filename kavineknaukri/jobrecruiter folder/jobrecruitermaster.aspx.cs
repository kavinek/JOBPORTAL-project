using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace kavineknaukri.jobrecruiter_folder
{
    
    public partial class jobrecruitermaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_tbljobrecruiter_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@jr_name", txtcomapnyname.Text);
            cmd.Parameters.AddWithValue("@jr_url", txtcomapnyurl.Text );
            cmd.Parameters.AddWithValue("@jr_email", txtemail.Text);
            cmd.Parameters.AddWithValue("@jr_password", txtpassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}