using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class DbConnection
    {
        public static SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9EHAL4D8;Initial Catalog=Example;Integrated Security=True");
            return sqlConnection;
        }
        public void InsertSalesman(string Salesman_ID,string Salesman_Name,string SalesMan_City,string commission)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9EHAL4D8;Initial Catalog=Example;Integrated Security=True");
            SqlCommand sqlCommand=new SqlCommand("insert into Salesman values("+Salesman_ID+",'"+Salesman_Name+"','"+SalesMan_City+"',"+commission+")",sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateSalesman(int salesmanId, string salesmanName, string city, string commision)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-9EHAL4D8; Initial Catalog = Example; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("update Salesman set name='" + salesmanName + "' , city='" + city + "' , commission=" + commision + " where salesman_id=" + salesmanId + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetSalesmans()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-9EHAL4D8; Initial Catalog = Example; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from Salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetSalesmanById(int salesmanId)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-9EHAL4D8; Initial Catalog = Example; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesman where salesman_id=" + salesmanId + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void  DeleteSalesmanbyID(int salesmanId)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-9EHAL4D8; Initial Catalog = Example; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("delete from Orders where salesman_id=" + salesmanId + "", sqlConnection);
            SqlCommand sqlCommand1 = new SqlCommand("delete from salesman where salesman_id=" + salesmanId + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
        }



        public void InsertCustomer(string C_ID,string C_name,string C_city,string C_grade,string Salesman_ID)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("Insert into Customer values(" + C_ID + ",'" + C_name + "','" + C_city + "'," + C_grade + "," + Salesman_ID + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetCustomer()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void UpdateCustomer(int C_Id, string C_Name, string C_City, string C_Grade, int SalesmanId)
        {

            SqlConnection sqlConnection = Connect();
            string sql = "update Customer set cust_name='" + C_Name + "' , city='" + C_City + "' , grade=" + C_Grade + ", salesman_id=" + SalesmanId + "where customer_id=" + C_Id + "";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();  
        }
        public DataTable GetCustomerById(int C_id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Customer where customer_ID=" + C_id + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void DeleteCustomer(int C_Id)
        {
            SqlConnection sqlConnection = Connect();
            string sql = "Delete From Customer where customer_ID=" + C_Id + "";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }






        public void InsertOrders(string order_no, string purch_amt, string order_date, string customer_id, string salesman_id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("insert into Orders values(" + order_no + "," + purch_amt + ",'" + order_date + "'," + customer_id + "," + salesman_id + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetOrders()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Orders", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public void UpdateOrders(int order_no, double purch_amt, string order_date, int customer_id, int salesman_id)
        {
            SqlConnection sqlConnection = Connect();

            string sql = "update Orders set purch_amt=" + purch_amt + " , ord_date='" + order_date + "' , customer_ID=" + customer_id + ", salesman_ID=" + salesman_id + "where order_no=" + order_no + "";

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetOrdersByNumber(int id)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Orders where ord_no=" + id + "", sqlConnection);

            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }


        public void DeleteOrder(int order_no)
        {
            SqlConnection sqlConnection = Connect();
            string sql = "Delete From Orders where ord_no=" + order_no;
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}