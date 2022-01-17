using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollService
{
    public class EmployeePayRollOperation
    {
        /// <summary>
        /// UC1-Threads are not used
        /// </summary>
        public List<EmployeeModel> employeePayrollDetail= new List<EmployeeModel>();
        public void addEmployeeToPayroll(List<EmployeeModel> employeePayrollDetails)
        {
            employeePayrollDetail.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePayrollDetail.ToString());

        }
        public void addEmployeePayroll(EmployeeModel emp)
        {
            employeePayrollDetail.Add(emp);
        }
    }
}
