using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace Assignment4
{
    
    public class DataBase
    {
        public static SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9EHAL4D8;Initial Catalog=EmployeeManagement;Integrated Security=True");
            return sqlConnection;
        }
        public void InsertDepartment(string D_Name)
        {
            SqlConnection sqlConnection = Connect();
            string Query = "insert into Department values('" + D_Name + "')";
            SqlCommand sql = new SqlCommand(Query,sqlConnection);
            sqlConnection.Open();
            sql.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateDepartment(int D_num,string D_Name)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("update Department set dept_name='" + D_Name + "' where dept_number=" + D_num + "" , sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetDepartment()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Department", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetDepartmentbynum(int D_num)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Department where dept_number = "+ D_num+"", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public void DeleteDept(int D_num)
        {
            SqlConnection sqlConnection = Connect();
            string sql = "Delete From Department where dept_number=" + D_num + "";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}