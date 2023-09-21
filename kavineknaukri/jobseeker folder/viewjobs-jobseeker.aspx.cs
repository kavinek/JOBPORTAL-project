using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace kavineknaukri.jobseeker_folder
{
    public partial class viewjobs_jobseeker : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
             {
                bindjobpost();
                bindjoblocation();
                bindjobprofile();
             }
        }

        public void bindjobpost()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobpost join tbljobrecruiter on tbljobpost.jr_id=tbljobrecruiter.jr_id join tbljobprofile on tbljobpost.jpr_id=tbljobprofile.jpr_id join tbljoblocation on tbljobpost.tjl_id=tbljoblocation.tjl_id where tbljobpost.status=0", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobs.DataSource = dt;
            gvjobs.DataBind();
                      
        }

        public void bindjoblocation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljoblocation", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddljoblocation.DataValueField = "tjl_id";
            ddljoblocation.DataTextField = "tjl_name";
            ddljoblocation.DataSource = dt;
            ddljoblocation.DataBind();
            ddljoblocation.Items.Insert(0, new ListItem("--SELECT LOCATION--", "0"));
            con.Close();
        }

    

        public void bindjobprofile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofile", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddljobprofile.DataValueField = "jpr_id";
            ddljobprofile.DataTextField = "jpr_name";
            ddljobprofile.DataSource = dt;
            ddljobprofile.DataBind();
            ddljobprofile.Items.Insert(0, new ListItem("--SELECT JOB--", "0"));
            con.Close();
        }

       
        protected void btnsearch2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobpost join tbljobrecruiter on tbljobpost.jr_id=tbljobrecruiter.jr_id join tbljobprofile on tbljobpost.jpr_id=tbljobprofile.jpr_id join tbljoblocation on tbljobpost.tjl_id=tbljoblocation.tjl_id where tbljobpost.status=0 and tbljobpost.tjl_id='" + ddljobprofile.SelectedValue + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobs.DataSource = dt;
            gvjobs.DataBind();
        }

        protected void btnsearch1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobpost join tbljobrecruiter on tbljobpost.jr_id=tbljobrecruiter.jr_id join tbljobprofile on tbljobpost.jpr_id=tbljobprofile.jpr_id join tbljoblocation on tbljobpost.tjl_id=tbljoblocation.tjl_id where tbljobpost.status=0 and tbljobpost.tjl_id='" + ddljoblocation.SelectedValue + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvjobs.DataSource = dt;
            gvjobs.DataBind();
        }
    }
}