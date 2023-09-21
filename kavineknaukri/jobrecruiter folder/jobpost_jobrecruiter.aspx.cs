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
    public partial class jobpost_jobrecruiter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindjobprofile();
                bindjoblocation();
                bindjobtype();
            }
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

        public void bindjobtype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobtype", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rbljobtype.DataValueField = "tjt_id";
            rbljobtype.DataTextField = "tjt_name";
            rbljobtype.DataSource = dt;
            rbljobtype.DataBind();
            con.Close();
        }

        public void bindjobprofile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofile", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddljobprofile.DataValueField="jpr_id";
            ddljobprofile.DataTextField="jpr_name";
            ddljobprofile.DataSource = dt;
            ddljobprofile.DataBind();
            ddljobprofile.Items.Insert(0,new ListItem("--SELECT JOB--","0"));
            con.Close();
        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("jobpost_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@jr_id",Session["JRID"]);
            cmd.Parameters.AddWithValue("@jpr_id",ddljobprofile.SelectedValue);
            cmd.Parameters.AddWithValue("@minexp",txtminexp.Text);
            cmd.Parameters.AddWithValue("@maxexp",txtmaxexp.Text);
            cmd.Parameters.AddWithValue("@minsalary",txtminsalary.Text);
            cmd.Parameters.AddWithValue("@maxsalary",txtmaxsalary.Text);
            cmd.Parameters.AddWithValue("@tjt_id",rbljobtype.SelectedValue);
            cmd.Parameters.AddWithValue("@tjl_id",ddljoblocation.SelectedValue);
            cmd.Parameters.AddWithValue("@noofvacany",txtnoofvacancy.Text);
            cmd.Parameters.AddWithValue("@comment",txtcomment.Text);
            cmd.ExecuteNonQuery();
        }
    }
}