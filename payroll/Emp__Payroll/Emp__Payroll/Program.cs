using System;

namespace Emp__Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll problem");
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetData();
          
        }
    }
}
