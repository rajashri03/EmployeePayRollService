using System;
using System.Collections.Generic;
using System.Data;
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
        //Created Connection file
        public const string ConnFile = @"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =PayrollService; Integrated Security = True;";
        SqlConnection connection = new SqlConnection(ConnFile);

        /// <summary>
        /// Method to insert data in database
        /// </summary>
        /// <param name="model"></param>
        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("SpEmployeePayroll", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@Deduction", model.Deduction);
                    cmd.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    cmd.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    cmd.Parameters.AddWithValue("@NetPay", model.NetPay);
                    cmd.Parameters.AddWithValue("@DepartMent", model.DepartMent);
                    this.connection.Open();var result = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
        /// <summary>
        /// Method to Update data in database
        /// </summary>
        /// <param name="model"></param>
        public bool UpdateEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("SpEmployeePayroll_Update", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@Deduction", model.Deduction);
                    cmd.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    cmd.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    cmd.Parameters.AddWithValue("@NetPay", model.NetPay);
                    cmd.Parameters.AddWithValue("@DepartMent", model.DepartMent);
                    this.connection.Open(); var result = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    }
}
