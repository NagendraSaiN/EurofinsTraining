using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable dtprojectResult = dataBase.GetProject();
            gvprojDetails.DataSource = dtprojectResult;
            gvprojDetails.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Proj_Name = "";
            string Start_date = "";
            Proj_Name = txtproj_name.Text;
            Start_date = txtproj_date.Text;
            DataBase dataBase = new DataBase();
            dataBase.InsertProject(Proj_Name, Start_date);
            DataTable dtprojectResult = dataBase.GetProject();
            gvprojDetails.DataSource = dtprojectResult;
            gvprojDetails.DataBind();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.UpdateProject(Convert.ToInt32(lblproj_num.Text), txtproj_name.Text, txtproj_date.Text);
            DataTable dtResult = dataBase.GetProject();
            gvprojDetails.DataSource = dtResult;
            gvprojDetails.DataBind();
            lblstatus.Text = "Credentials Updated.Please check the table below";


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtproj_date.Text = string.Empty;
            txtproj_name.Text = string.Empty;
            lblproj_num.Text = string.Empty;
        }

        protected void gvprojDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Proj_num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                //string dept_num = ddldept_num.SelectedValue;
                DataBase db = new DataBase();
                DataTable dt = db.GetProjectbynum(Proj_num);
                lblproj_num.Text = dt.Rows[0][0].ToString();
                txtproj_name.Text = dt.Rows[0][1].ToString();
                txtproj_date.Text = dt.Rows[0][2].ToString();
                lblstatus.Text = "Credentials Edited.Please check the table below";
            }
            else if (e.CommandName == "Delete")
            {
                DataBase db = new DataBase();
                db.Deleteproj(Proj_num);
                DataTable Result = db.GetProject();
                gvprojDetails.DataSource = Result;
                gvprojDetails.DataBind();
                lblstatus.Text = "Credentials Deleted.Please check the table below";
            }

        }

        protected void gvprojDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvprojDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}