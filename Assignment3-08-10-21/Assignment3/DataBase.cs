using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Assignment3
{
   
    public class DataBase
    {
        //SQL Connection Establishment
        public static SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-9EHAL4D8;Initial Catalog=EmployeeManagement;Integrated Security=True");
            return sqlConnection;
        }
        #region Department
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
        #endregion


        #region Project
        public void InsertProject(string P_Name,string P_date)
        {
            SqlConnection sqlConnection = Connect();
            string Query = "insert into Project values('" + P_Name + "','" + P_date + "')";
            SqlCommand sql = new SqlCommand(Query, sqlConnection);
            sqlConnection.Open();
            sql.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetProject()
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Project", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public void UpdateProject(int P_num, string P_Name,string P_Date)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("update Project set proj_name='" + P_Name + "',startdate='"+P_Date+"' where project_number=" + P_num + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetProjectbynum(int P_num)
        {
            SqlConnection sqlConnection = Connect();
            SqlCommand sqlCommand = new SqlCommand("select * from Project where project_number = " + P_num + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }

        public void Deleteproj(int P_num)
        {
            SqlConnection sqlConnection = Connect();
            string sql = "Delete From Project where project_number=" + P_num + "";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
        #region Employee

        //Employee Webform is done using Dis Connected approach
        // Method to execute all queries
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = Connect();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void InsertEmployee(string title, string first, string last, string gender, string DOB, string DOJ, int dept_id, int proj_id)
        {
            string query = "insert into Employee values ('" + title + "'," + "'" + first + "', '" + last + "','" + gender + "',' " + DOB + "', '" + DOJ + "'," + dept_id + "," + proj_id + ")";
            ExecuteQuery(query);
        }

        public DataTable GetEmployees()
        {
            string query = "select * from Employee";
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public DataTable GetEmployeeById(int emp_id)
        {
            string query = "select * from Employee where emp_id=" + emp_id;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public DataTable GetEmployeeByDeptId(int dept_id)
        {
            string query = "select * from Employee where dept_number=" + dept_id;
            DataTable dt = ExecuteQuery(query);
            return dt;
        }

        public void DeleteEmployee(int emp_id)
        {
            string query = "delete from Employee where emp_id=" + emp_id;
            ExecuteQuery(query);
        }

        public void UpdateEmployee(int Emp_id, string title, string first, string last, string gender, string DOB, string DOJ, string dept_id, int proj_id)
        {
            string query = "update Employee set title='" + title + "'," + "first_name='" + first + "', last_name='" + last + "',gender ='" + gender + "',DOB =' " + DOB + "', Hired_date='" + DOJ + "',dept_number=" + dept_id + ",project_number=" + proj_id + "where emp_id=" + Emp_id;
            ExecuteQuery(query);
        }
        #endregion
    }
}