using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dtCustomerResult = dbConnection.GetCustomer();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string C_ID="",C_name="",C_city="",C_grade="",Salesman_ID="";
            C_ID = txtCustomer_ID.Text;
            C_name = txtCustomer_Name.Text;
            C_city = txtCustomer_City.Text;
            C_grade = txtCustomer_Grade.Text;
            Salesman_ID = txtSalesman_ID.Text;
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertCustomer(C_ID, C_name, C_city, C_grade, Salesman_ID);
            DataTable Result = dbConnection.GetCustomer();
            gvCustomerDetails.DataSource = Result;
            gvCustomerDetails.DataBind();
            lblstatus.Text = "Credentials Saved.Please check the table below";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateCustomer(Convert.ToInt32(txtCustomer_ID.Text), txtCustomer_Name.Text, txtCustomer_City.Text, txtCustomer_Grade.Text, Convert.ToInt32(txtSalesman_ID.Text));
            DataTable dtCustomerResult = dbConnection.GetCustomer();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
            lblstatus.Text = "Credentials Updated.Please check the table below";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void gvCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Customer_ID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetCustomerById(Customer_ID);
                txtCustomer_ID.Text = dt.Rows[0][0].ToString();
                txtCustomer_Name.Text = dt.Rows[0][1].ToString();
                txtCustomer_City.Text = dt.Rows[0][2].ToString();
                txtCustomer_Grade.Text = dt.Rows[0][3].ToString();
                txtSalesman_ID.Text = dt.Rows[0][4].ToString();
                lblstatus.Text = "Credentials Edited.Please check the table below";

            }
            else if (e.CommandName == "Delete")
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteCustomer(Customer_ID);
                DataTable Result = dbConnection.GetCustomer();
                gvCustomerDetails.DataSource = Result;
                gvCustomerDetails.DataBind();
                lblstatus.Text = "Credentials Deleted.Please check the table below";

            }
        }

        protected void gvCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvCustomerDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}