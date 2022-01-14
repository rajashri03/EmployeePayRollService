using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollService
{
    public class EmployeeModel
    {
        public string EmployeeName  { get; set; }
        public string Gender { get; set; }
        public int BasicPay { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Deduction { get; set; }
        public string TaxablePay { get; set; }
        public string IncomeTax { get; set; }
        public string NetPay { get; set; }
        public string DepartMent { get; set; }
    }
}
