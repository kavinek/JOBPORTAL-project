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
    public partial class changepasswordjobseeker : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncp_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == txtconfirmnewpassword.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tbljobseeker set js_password='"+txtnewpassword.Text+"' where js_password='"+txtcurrentpassword.Text+"' and js_id='"+Session["JSID"]+"'", con);
                int i = cmd.ExecuteNonQuery();  /*executenonquerry returns an integer value (any 0-1-2-3 )*/
                con.Close();
                if(i==0)
                {
                    lblmsg.Text = "CURRENT PASSWORD DO NOT MATCH ";
                }
                else
                {
                    lblmsg.Text = "PASSWORD CHANGED SUCESSFULLY";
                }
              
            }
            else
            {
                lblmsg.Text = "PASSWORD UPDATE FAIL ";
            }
        }
    }
}