using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Data.Entity;
using OrderManagementData;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dtSalesmanResult = dbConnection.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //string salesman_ID = "";
            //string salesman_Name = "";
            //string salesman_city = "";
            //string commission = "";
            //salesman_ID = txtSalesman_ID.Text;
            //salesman_Name = txtSalesman_Name.Text;
            //salesman_city = txtSalesman_City.Text;
            //commission = txtSalesman_Commission.Text;
            //DbConnection dbConnection = new DbConnection();
            //dbConnection.InsertSalesman(salesman_ID,salesman_Name, salesman_city, commission);

            //DataTable dtSalesmanResult = dbConnection.GetSalesmans();
            //gvSalesmanDetails.DataSource = dtSalesmanResult;
            //gvSalesmanDetails.DataBind();
            //lblstatus.Text = "Credentials Saved.Please check the table below";
            ExampleEntities exampleEntities = new ExampleEntities();
            OrderManagementData.Salesman salesman = new OrderManagementData.Salesman();
            salesman.salesman_ID = Convert.ToInt32(txtSalesman_ID.Text);
            salesman.Name = txtSalesman_Name.Text;
            salesman.City = txtSalesman_City.Text;
            salesman.Commission = Convert.ToDecimal(txtSalesman_Commission.Text);

            exampleEntities.Salesmen.Add(salesman);
            exampleEntities.SaveChanges();
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateSalesman(Convert.ToInt32(txtSalesman_ID.Text), txtSalesman_Name.Text, txtSalesman_City.Text, txtSalesman_Commission.Text);
            DataTable dtSalesmanResult = dbConnection.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
            lblstatus.Text = "Credentials Updated.Please check the table below";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dtSalesmanResult = dbConnection.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void gvSalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesmanid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetSalesmanById(salesmanid);
                txtSalesman_ID.Text = dt.Rows[0][0].ToString();
                txtSalesman_Name.Text = dt.Rows[0][1].ToString();
                txtSalesman_City.Text = dt.Rows[0][2].ToString();
                txtSalesman_Commission.Text = dt.Rows[0][3].ToString();
                lblstatus.Text = "Credentials Edited.Please check the table below";
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteSalesmanbyID(salesmanid);
                DataTable dtSalesmanResult = dbConnection.GetSalesmans();
                gvSalesmanDetails.DataSource = dtSalesmanResult;
                gvSalesmanDetails.DataBind();
                lblstatus.Text = "Credentials Deleted.Please check the table below";
            }
        }

        protected void gvSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
    
}