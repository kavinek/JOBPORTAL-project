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
    public partial class managecity : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindcity();
                bindcountry();
                ddlstate.Items.Insert(0, new ListItem("--SLECET STATE--", "0"));
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
            SqlCommand cmd = new SqlCommand("select * from tblstate", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlstate.DataTextField = "ts_name";
            ddlstate.DataValueField = "ts_id";
            ddlstate.DataSource = dt;
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, new ListItem("--SLECET STATE--", "0"));

        }

        public void bindcity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcity join tblstate on tblcity.ts_id=tblstate.ts_id join tblcountry on  tblcity.tc_id=tblcountry.tc_id", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gvcity.DataSource = dt;
            gvcity.DataBind();
        }


            protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblcity(tc_id,ts_id,tcity_name)values('" + ddlcountry.SelectedValue + "','"+ddlstate.SelectedValue+"','" + txtcityname.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindstate();
        }
    }
}