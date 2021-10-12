using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment3
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable Result = db.GetEmployees();
            gvEmployeeDetails.DataSource = Result;
            gvEmployeeDetails.DataBind();
            DataTable dtDeptResult = db.GetDepartment();
            dept_number.Items.Add("-- Choose --");
            DataTable dtProjResult = db.GetProject();
            project_number.Items.Add("-- Choose --");

            for (int i = 0; i < dtDeptResult.Rows.Count; i++)
            {
                dept_number.Items.Add(new ListItem(dtDeptResult.Rows[i][0].ToString() + " - " + dtDeptResult.Rows[i][1], dtDeptResult.Rows[i][0].ToString()));
            }

            for (int i = 0; i < dtProjResult.Rows.Count; i++)
            {
                project_number.Items.Add(new ListItem(dtProjResult.Rows[i][0].ToString() + " - " + dtProjResult.Rows[i][1], dtProjResult.Rows[i][0].ToString()));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            int deptId = Convert.ToInt32(dept_number.SelectedValue.ToString());
            int projId = Convert.ToInt32(project_number.SelectedValue.ToString());

            db.InsertEmployee(title.Text, first_name.Text, last_name.Text, gender.Text, DOB.Text, Hired_date.Text, deptId, projId);

            DataTable dtEmployeeResult = db.GetEmployees();
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string DeptId = dept_number.SelectedValue.ToString();
            int projId = Convert.ToInt32(project_number.SelectedValue.ToString());

            db.UpdateEmployee(Convert.ToInt32(emp_id.Text), title.Text, first_name.Text, last_name.Text, gender.Text, DOB.Text.ToString(), Hired_date.Text.ToString(), DeptId, projId);
            DataTable dtEmployeeResult = db.GetEmployees();
            gvEmployeeDetails.DataSource = dtEmployeeResult;
            gvEmployeeDetails.DataBind();
        }

        protected void gvEmployeeDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Emp_id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DataBase db = new DataBase();
                DataTable dtEmployeeResult = db.GetEmployeeById(Emp_id);

                title.Text = dtEmployeeResult.Rows[0][1].ToString();
                first_name.Text = dtEmployeeResult.Rows[0][2].ToString();
                last_name.Text = dtEmployeeResult.Rows[0][3].ToString();
                gender.Text = dtEmployeeResult.Rows[0][4].ToString();
                DOB.Text = dtEmployeeResult.Rows[0][5].ToString();
                Hired_date.Text = dtEmployeeResult.Rows[0][6].ToString();
                dept_number.Text = dtEmployeeResult.Rows[0][7].ToString();
                project_number.Text = dtEmployeeResult.Rows[0][8].ToString();
                emp_id.Text = dtEmployeeResult.Rows[0][0].ToString();
            }
            else
            {
                DataBase db = new DataBase();
                db.DeleteEmployee(Emp_id);

                DataTable dtEmployeeResult = db.GetEmployees();
                gvEmployeeDetails.DataSource = dtEmployeeResult;
                gvEmployeeDetails.DataBind();
            }
        }

        protected void gvEmployeeDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvEmployeeDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}