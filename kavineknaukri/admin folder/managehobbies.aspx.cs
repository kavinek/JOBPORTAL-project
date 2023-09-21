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
    public partial class managehobbies : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                bindhobbiesname();
            }

        }

        public void bindhobbiesname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblhobbies", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gvhobbies.DataSource = dt;
            gvhobbies.DataBind();
            con.Close();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblhobbies(th_name)values('" + txthobbiesname.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}