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
    public partial class changepasswordjobrecruiter : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("update tbljobrecruiter set jr_password='" + txtnewpassword.Text + "' where jr_password='" + txtcurrentpassword.Text + "' and jr_id='" + Session["JRID"] + "'", con);
                int i = cmd.ExecuteNonQuery();  /*executenonquerry returns an integer value (any 0-1-2-3 )*/
                con.Close();
                if (i == 0)
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