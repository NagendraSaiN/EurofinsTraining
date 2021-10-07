using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            DataTable dtOrdersResult = dbConnection.GetOrders();
            gvOrdersDetails.DataSource = dtOrdersResult;
            gvOrdersDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertOrders(order_no.Text, purch_amt.Text, order_date.Text, Customer_id.Text, Salesman_id.Text);
            DataTable dtOrdersResult = dbConnection.GetOrders();
            gvOrdersDetails.DataSource = dtOrdersResult;
            gvOrdersDetails.DataBind();
            lblstatus.Text = "Credentials Saved.Please check the table below";
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9EHAL4D8;Initial Catalog=Example;Integrated Security=True");
            string sql = "update Orders set purch_amt=" + purch_amt.Text + " , ord_date='" + order_date.Text + "' , customer_ID=" + Customer_id.Text + ", salesman_ID=" + Salesman_id.Text + "where ord_no=" + order_no.Text + "";
            SqlCommand Command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            Command.ExecuteNonQuery();
            sqlConnection.Close();
            DataTable dtOrdersResult = dbConnection.GetOrders();
            gvOrdersDetails.DataSource = dtOrdersResult;
            gvOrdersDetails.DataBind();
            lblstatus.Text = "Credentials Updated.Please check the table below";
        }

        protected void gvOrdersDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int number = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetOrdersByNumber(number);

                order_no.Text = dt.Rows[0][0].ToString();
                purch_amt.Text = dt.Rows[0][1].ToString();
                order_date.Text = dt.Rows[0][2].ToString();
                Customer_id.Text = dt.Rows[0][3].ToString();
                Salesman_id.Text = dt.Rows[0][4].ToString();
                lblstatus.Text = "Credentials Edited.Please check the table below";

            }
            else if (e.CommandName == "Delete")
            {
                DbConnection db = new DbConnection();
                db.DeleteOrder(number);
                DataTable dtSalesmanResult = db.GetOrders();
                gvOrdersDetails.DataSource = dtSalesmanResult;
                gvOrdersDetails.DataBind();
                lblstatus.Text = "Credentials Deleted.Please check the table below";

            }
        }

        protected void gvOrdersDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvOrdersDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}