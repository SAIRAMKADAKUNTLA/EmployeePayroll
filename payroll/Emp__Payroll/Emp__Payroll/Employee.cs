using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Emp__Payroll
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }

    }
}
