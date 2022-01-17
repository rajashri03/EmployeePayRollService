using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollService
{
    public class EmployeeModel
    {
        //POCO model/Properties
        public int EmployeeId { get; set; }
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

        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeModel(int EmployeeId,string EmployeeName,string Gender,int BasicPay,string PhoneNumber,string Address,string Deduction,string TaxablePay, string IncomeTax,string NetPay,string DepartMent)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
            this.DepartMent = DepartMent;
        }
    }
}
