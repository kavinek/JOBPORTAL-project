using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace kavineknaukri.jobseeker_folder
{
    public partial class jobseekermaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"data source=KAVINEKCOMPUTER\SQLEXPRESS;initial catalog=DB_JOBPORTAL220723;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                bindgender();
                bindjobprofile();
                bindqualification();
                bindcountry();
                ddlstate.Items.Insert(0, new ListItem("--SELECT STATE--", "0"));
                ddlstate.Items.Insert(0, new ListItem("--SELECT CITY--", "0"));
                ddlstate.Enabled = false;
                ddlcity.Enabled = false;
                tr_skills.Visible = false;
            }


            if (Request.QueryString["idd"] != null && Request.QueryString["idd"] != "")
            {
                if (!IsPostBack)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from tbljobseeker where js_id='" + Request.QueryString["idd"] + "' ", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();

                    txtname.Text = dt.Rows[0]["js_name"].ToString();
                    rblgender.SelectedValue = dt.Rows[0]["js_gender"].ToString();
                    txtdob.Text = dt.Rows[0]["js_dob"].ToString();
                    txtemail.Text = dt.Rows[0]["js_email"].ToString();
                    txtpassword.Text = dt.Rows[0]["js_password"].ToString();
                    ddlqualification.SelectedValue = dt.Rows[0]["js_qualification"].ToString();
                    ddljobprofile.SelectedValue = dt.Rows[0]["js_jobprofile"].ToString();
                    ddlcountry.SelectedValue = dt.Rows[0]["js_country"].ToString();

                    bindstate();
                    ddlstate.SelectedValue = dt.Rows[0]["js_state"].ToString();

                    bindcity();
                    ddlcity.SelectedValue = dt.Rows[0]["js_city"].ToString();


                    tr_skills.Visible = true;
                    bindjobskills();
                    string[] arr = dt.Rows[0]["js_skills"].ToString().Split(',');

                    for (int i = 0; i < cblskills.Items.Count; i++)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (cblskills.Items[i].ToString() == arr[j])
                            {
                                cblskills.Items[i].Selected = true;
                            }
                        }
                    }

                    //file upload name k control cannot store any value inside itself so we will use viewstate//

                    ViewState["img"] = dt.Rows[0]["js_image"].ToString();
                    ViewState["rsm"] = dt.Rows[0]["js_resume"].ToString();

                    btnregister.Text = "UPDATE";
                }
            }
        }



        public void bindgender()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblgender", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            rblgender.DataValueField = "tg_id";
            rblgender.DataTextField = "tg_name";
            rblgender.DataSource = dt;
            rblgender.DataBind();
        }

        public void bindjobprofile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofile", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddljobprofile.DataValueField = "jpr_id";
            ddljobprofile.DataTextField = "jpr_name";
            ddljobprofile.DataSource = dt;
            ddljobprofile.DataBind();
            ddljobprofile.Items.Insert(0, new ListItem("--SELECT JOB PROFILE--", "0"));
        }

        public void bindjobskills()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbljobprofileskills where jpr_id='"+ddljobprofile.SelectedValue+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            tr_skills.Visible = true;
            cblskills.DataValueField = "tsk_id";
            cblskills.DataTextField = "tsk_name";
            cblskills.DataSource = dt;
            cblskills.DataBind();
           
        }

        public void bindqualification()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblqualification", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlqualification.DataValueField = "tql_id";
            ddlqualification.DataTextField = "tql_name";
            ddlqualification.DataSource = dt;
            ddlqualification.DataBind();
            ddlqualification.Items.Insert(0, new ListItem("--SELECT QUALIFICATION--", "0"));
        }

        public void bindcountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcountry", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlcountry.DataValueField = "tc_id";
            ddlcountry.DataTextField = "tc_name";
            ddlcountry.DataSource = dt;
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, new ListItem("--SELECT COUNTRY--", "0"));
        }
       

        public void bindstate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblstate where tc_id='"+ddlcountry.SelectedValue+"' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlstate.Enabled = true;
            ddlstate.DataValueField = "ts_id";
            ddlstate.DataTextField = "ts_name";
            ddlstate.DataSource = dt;
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, new ListItem("--SELECT STATE--", "0"));
        }

        public void bindcity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcity where ts_id='"+ddlstate.SelectedValue+"' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ddlcity.Enabled = true;
            ddlcity.DataValueField = "tcity_id";
            ddlcity.DataTextField = "tcity_name";
            ddlcity.DataSource = dt;
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, new ListItem("--SELECT CITY--", "0"));
        }

                     


        protected void btnregister_Click(object sender, EventArgs e)
        { 
            if(btnregister.Text=="REGISTER")
            { 
            string kk = "";
            for(int i =0; i < cblskills.Items.Count; i++)
            { 
                if(cblskills.Items[i].Selected==true)
                 {
                     kk += cblskills.Items[i] + ",";
                 }
            }

            kk = kk.TrimEnd(',');


            //to know file name of uploaded image
            string imagename=Path.GetFileName(fuimage.PostedFile.FileName);
            //to save uploaded image in the folder 
            fuimage.SaveAs(Server.MapPath("JOBSEEKERIMAGES" + "\\" + imagename));
            //to know file name of uploaded resume
            string resumename=Path.GetFileName(furesume.PostedFile.FileName);
            //to save uploaded resume in the folder 
            furesume.SaveAs(Server.MapPath("JOBSEEKERRESUME" + "\\" + resumename));

            con.Open();
            SqlCommand cmd = new SqlCommand("proc_tbljobseeker_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@js_name", txtname.Text);
            cmd.Parameters.AddWithValue("@js_gender", rblgender.SelectedValue);
            cmd.Parameters.AddWithValue("@js_email", txtemail.Text);
            cmd.Parameters.AddWithValue("@js_password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@js_dob", txtdob.Text);
            cmd.Parameters.AddWithValue("@js_qualification", ddlqualification.SelectedValue);
            cmd.Parameters.AddWithValue("@js_jobprofile",ddljobprofile.SelectedValue);
            cmd.Parameters.AddWithValue("@js_skills",kk);
            //for cbl.selectedvalue it will only insert 1 skills out of all to solve this we will use loops// 
            cmd.Parameters.AddWithValue("@js_country",ddlcountry.SelectedValue );
            cmd.Parameters.AddWithValue("@js_state",ddlstate.SelectedValue );
            cmd.Parameters.AddWithValue("@js_city",ddlcity.SelectedValue );
            //HAMESHA DATABASE M IMAGE/RESUME KA NAME BHEJTE HAI
            cmd.Parameters.AddWithValue("@js_image", imagename );
            cmd.Parameters.AddWithValue("@js_resume",resumename);
            cmd.ExecuteNonQuery();
            con.Close();
            }


            else if (btnregister.Text=="UPDATE")
            { 
                    string kk = "";
                 for(int i =0; i < cblskills.Items.Count; i++)
                 { 
                  if(cblskills.Items[i].Selected==true)
                     {
                         kk += cblskills.Items[i] + ",";
                     }
                 }

            kk = kk.TrimEnd(',');
              
                
            //to know file name of uploaded image
            string imagename=  Path.GetFileName(fuimage.PostedFile.FileName);
             
                if (imagename != null)
                {
                    imagename = DateTime.Now.Ticks.ToString() + imagename;
                    //to save uploaded image in the folder 
                    fuimage.SaveAs(Server.MapPath("JOBSEEKERIMAGES" + "\\" + imagename));
                    //to delete preexiting image and resume of existing jobseeker in folder
                    File.Delete(Server.MapPath("JOBSEEKERIMAGES" + "\\" + ViewState["img"]));
                }
                                
                //to know file name of uploaded resume
                string resumename =  Path.GetFileName(furesume.PostedFile.FileName);


                if (resumename != null)
                {
                    resumename = DateTime.Now.Ticks.ToString() + resumename;
                    //to save uploaded resume in the folder 
                    furesume.SaveAs(Server.MapPath("JOBSEEKERRESUME" + "\\" + resumename));
                    //to delete preexiting image and resume of existing jobseeker in folder
                    File.Delete(Server.MapPath("JOBSEEKERRESUME" + "\\" + ViewState["rsm"]));
                }

            con.Open();
            SqlCommand cmd = new SqlCommand("proc_tbljobseeker_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@js_id", Request.QueryString["idd"]);
            cmd.Parameters.AddWithValue("@js_name", txtname.Text);
            cmd.Parameters.AddWithValue("@js_gender", rblgender.SelectedValue);
            cmd.Parameters.AddWithValue("@js_email", txtemail.Text);
            cmd.Parameters.AddWithValue("@js_password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@js_dob",txtdob.Text);
            cmd.Parameters.AddWithValue("@js_qualification", ddlqualification.SelectedValue);
            cmd.Parameters.AddWithValue("@js_jobprofile",ddljobprofile.SelectedValue);
            cmd.Parameters.AddWithValue("@js_skills",kk);
            //for cbl.selectedvalue it will only insert 1 skills out of all to solve this we will use loops// 
            cmd.Parameters.AddWithValue("@js_country",ddlcountry.SelectedValue );
            cmd.Parameters.AddWithValue("@js_state",ddlstate.SelectedValue );
            cmd.Parameters.AddWithValue("@js_city",ddlcity.SelectedValue );
            //HAMESHA DATABASE M IMAGE/RESUME KA NAME BHEJTE HAI
            cmd.Parameters.AddWithValue("@js_image", imagename==""?ViewState["img"]:imagename);
            cmd.Parameters.AddWithValue("@js_resume", resumename==""?ViewState["rsm"]:resumename);
            cmd.ExecuteNonQuery();
            con.Close();
            }

        }

              
        protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindstate();
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindcity();
        }

        protected void ddljobprofile_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindjobskills();
        }
    }
}