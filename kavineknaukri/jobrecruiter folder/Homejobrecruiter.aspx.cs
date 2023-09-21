using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace kavineknaukri.jobrecruiter_folder
{
    public partial class Homejobrecruiter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindjobrecruiter();
            }
        }

        public void bindjobrecruiter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobrecruiter where jr_id='" + Session["JRID"] + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            lblname.Text = dt.Rows[0]["jr_name"].ToString();
            lblurl.Text = dt.Rows[0]["jr_url"].ToString();
            lblemail.Text = dt.Rows[0]["jr_email"].ToString();
            lblpassword.Text = dt.Rows[0]["jr_password"].ToString();
        }
    }
}