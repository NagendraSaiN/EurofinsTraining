using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataBase dataBase = new DataBase();
                DataTable dt = dataBase.GetDepartment();
                ddldept_num.Items.Add("---------Select---------");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddldept_num.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }
                DataTable dtCustomerResult = dataBase.GetDepartment();
                gvDeptDetails.DataSource = dtCustomerResult;
                gvDeptDetails.DataBind();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string dept_Name = "";
            dept_Name = txtDep_Name.Text;
            DataBase dataBase = new DataBase();
            dataBase.InsertDepartment(dept_Name);
            DataTable dtSalesmanResult = dataBase.GetDepartment();
            gvDeptDetails.DataSource = dtSalesmanResult;
            gvDeptDetails.DataBind();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
        
            DataBase dataBase = new DataBase();
            string dept_num = ddldept_num.SelectedValue;
            dataBase.UpdateDepartment(Convert.ToInt32(lblDep_num.Text),txtDep_Name.Text);
            DataTable dtSalesmanResult = dataBase.GetDepartment();
            gvDeptDetails.DataSource = dtSalesmanResult;
            gvDeptDetails.DataBind();
            lblstatus.Text = "Credentials Updated.Please check the table below";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtDep_Name.Text = string.Empty;
            lblDep_num.Text = string.Empty;
        }

        protected void gvDeptDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Dept_num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                string dept_num = ddldept_num.SelectedValue;
                DataBase db = new DataBase();
                DataTable dt = db.GetDepartmentbynum(Dept_num);
                lblDep_num.Text = dt.Rows[0][0].ToString();
                txtDep_Name.Text = dt.Rows[0][1].ToString();
                lblstatus.Text = "Credentials Edited.Please check the table below";
            }
            else if (e.CommandName == "Delete")
            {
                DataBase db = new DataBase();
                db.DeleteDept(Dept_num);
                DataTable Result = db.GetDepartment();
                gvDeptDetails.DataSource = Result;
                gvDeptDetails.DataBind();
                lblstatus.Text = "Credentials Deleted.Please check the table below";

            }

        }

        protected void gvDeptDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvDeptDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        
    }
}