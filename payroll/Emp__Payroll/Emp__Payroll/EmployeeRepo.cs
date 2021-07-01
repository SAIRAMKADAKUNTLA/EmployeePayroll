using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Emp__Payroll
{
    class EmployeeRepo
    {
        public static string connectionString = @"Data Source=DESKTOP-P4G3D0S;Initial Catalog = PayrollService; Integrated Security = True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetData()
        {
            try
            {
                Employee emp = new Employee();
                using (this.connection)
                {
                    string query = @"SELECT EmployeeName, Gender, Department, PhoneNumber, Address, Basic_Pay, StartingDate FROM EmpPayroll;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            emp.EmployeeName = reader.GetString(0);
                            emp.Gender = reader.GetString(1);
                            emp.Department = reader.GetString(2);
                            emp.PhoneNumber = reader.GetString(3);
                            emp.Address = reader.GetString(4);
                            emp.BasicPay = reader.GetDouble(5);
                            emp.StartingDate = reader.GetDateTime(6);
                        }
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", emp.EmployeeName, emp.Gender, emp.Department, emp.PhoneNumber, emp.Address, emp.BasicPay, emp.StartingDate);
                    }
                    else
                    {
                        Console.WriteLine("NO DATA FOUND");
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
