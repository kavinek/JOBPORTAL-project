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
    public partial class managejobrecruiter : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("select * from tbljobrecruiter ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobrecruiter.DataSource = dt;
            gvjobrecruiter.DataBind();
        }

        protected void gvjobrecruiter_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("jobrecruiter_statuschange", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@jr_id", e.CommandArgument);
            cmd.ExecuteNonQuery();
            con.Close();
            bindjobrecruiter();
        }
    }
}