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
    public partial class managejobprofileskills : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindjobprofile();
                bindskills();
            }
        }

        public void bindjobprofile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofile", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddljobprofile.DataTextField = "jpr_name";
            ddljobprofile.DataValueField = "jpr_id";
            ddljobprofile.DataSource = dt;
            ddljobprofile.DataBind();
            ddljobprofile.Items.Insert( 0, new ListItem("--SELECT JOB PROFILE--", "0"));
        }

        public void bindskills()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofileskills join tbljobprofile on tbljobprofileskills.jpr_id=tbljobprofile.jpr_id", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobskills.DataSource = dt;
            gvjobskills.DataBind();
        }

            protected void btnsaveskills_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbljobprofileskills(jpr_id,tsk_name)values('"+ddljobprofile.SelectedValue+"','"+txtskillname.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            bindskills();
        }
    }
}