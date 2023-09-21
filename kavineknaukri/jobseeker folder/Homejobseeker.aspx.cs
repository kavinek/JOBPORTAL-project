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
    
    public partial class Homejobseeker : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
           {
                bindjobseeker();
             
           }
        }

       

        public void bindjobseeker()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("jobseeker_joinone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@js_id", Session["JSID"]);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            lblname.Text = dt.Rows[0]["js_name"].ToString();
            lblgender.Text = dt.Rows[0]["tg_name"].ToString()=="1"?"MALE":dt.Rows[0]["tg_name"].ToString()=="2"?"FEMALE":"OTHERS";
            lbldob.Text = dt.Rows[0]["js_dob"].ToString();
            lblemail.Text = dt.Rows[0]["js_email"].ToString();
            lblpassword.Text = dt.Rows[0]["js_password"].ToString();
            lblqualification.Text = dt.Rows[0]["tql_name"].ToString();
            lbljobprofile.Text = dt.Rows[0]["jpr_name"].ToString();
            lblskills.Text = dt.Rows[0]["js_skills"].ToString();
            lbladdress.Text = dt.Rows[0]["tcity_name"].ToString()+" , "+ dt.Rows[0]["ts_name"].ToString() + " , " + dt.Rows[0]["tc_name"].ToString();
            imgjs.ImageUrl = "../jobseeker folder\\JOBSEEKERIMAGES\\" + dt.Rows[0]["js_image"].ToString();
            btnresumeshow.Text = dt.Rows[0]["js_resume"].ToString();
        }

        protected void btnresumeshow_Click(object sender, EventArgs e)
        {
            Response.Redirect("../jobseeker folder\\JOBSEEKERRESUME\\" + btnresumeshow.Text);
        }

        protected void editbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("jobseekermaster.aspx?idd="+ Session["JSID"]);
        }
    }
}