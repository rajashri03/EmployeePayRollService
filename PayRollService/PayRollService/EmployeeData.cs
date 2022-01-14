using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollService
{
    public class EmployeeData
    {
        /// <summary>
        /// Create Database-Payroll Service
        /// </summary>
        public static void Create_Database()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =master; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create database PayrollService;;", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("PayrollService; Database created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }
        /// <summary>
        /// Create Table-Employee_PayRoll
        /// </summary>
        public static void CreateTables()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =PayrollService; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Payroll table has been  created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
    }
}
