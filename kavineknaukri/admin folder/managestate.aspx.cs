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
    public partial class managestate : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindstate();
                bindcountry();
            }
        }

        public void bindcountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcountry", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlcountry.DataTextField = "tc_name";
            ddlcountry.DataValueField = "tc_id";
            ddlcountry.DataSource = dt;
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, new ListItem("--SLECET COUNTRY--", "0"));
        }

        public void bindstate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblstate join tblcountry on tblstate.tc_id=tblcountry.tc_id", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gvstate.DataSource = dt;
            gvstate.DataBind();
            con.Close();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblstate(tc_id,ts_name)values('"+ddlcountry.SelectedValue+"','" + txtstatename.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}