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
            DataTable dt = dbConnection.GetSalesmanIds();
            ddlSalesmanid.Items.Add("---------Select---------");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlSalesmanid.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            DataTable dtCustomerResult = dbConnection.GetCustomer();
            gvCustomerDetails.DataSource = dtCustomerResult;
            gvCustomerDetails.DataBind();
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            int Salesman_ID = Convert.ToInt32(ddlSalesmanid.SelectedValue.ToString());
            var salesmanname =  ddlSalesmanid.SelectedItem.Text;
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertCustomer(2019, txtCustomer_Name.Text, txtCustomer_City.Text, txtCustomer_Grade.Text,Salesman_ID);
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
            txtCustomer_ID.Text = string.Empty;
            txtCustomer_Name.Text = string.Empty;
            txtCustomer_Grade.Text = string.Empty;
            txtCustomer_City.Text = string.Empty;
            txtSalesman_ID.Text = string.Empty;

        }

        protected void gvCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Customer_ID = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                string Salesman_ID = ddlSalesmanid.SelectedValue;
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetCustomerById(Customer_ID);
                txtCustomer_ID.Text = dt.Rows[0][0].ToString();
                txtCustomer_Name.Text = dt.Rows[0][1].ToString();
                txtCustomer_City.Text = dt.Rows[0][2].ToString();
                txtCustomer_Grade.Text = dt.Rows[0][3].ToString();
                txtSalesman_ID.Text = Salesman_ID;
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