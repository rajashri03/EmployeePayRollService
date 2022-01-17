using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayRollService;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC1-Without Thread
        [TestMethod]
        public void Given5Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeModel> employeeDetails = new List<EmployeeModel>();
            employeeDetails.Add(new EmployeeModel(EmployeeId: 1, EmployeeName: "Rajashri", Gender: "F", BasicPay: 25000, PhoneNumber: "9898887878", Address: "Kagal", Deduction: "500", TaxablePay: "100", IncomeTax: "200", NetPay:"2000", DepartMent:"IT"));
            employeeDetails.Add(new EmployeeModel(EmployeeId: 2, EmployeeName: "Jyoti", Gender: "F", BasicPay: 15000, PhoneNumber: "7666655544", Address: "Kagal", Deduction: "500", TaxablePay: "100", IncomeTax: "200", NetPay:"2000", DepartMent:"IT"));
            employeeDetails.Add(new EmployeeModel(EmployeeId: 3, EmployeeName: "Riddhi", Gender: "F", BasicPay:35000, PhoneNumber: "7655887878", Address: "Kagal", Deduction: "500", TaxablePay: "100", IncomeTax: "200", NetPay:"2000", DepartMent:"IT"));
            employeeDetails.Add(new EmployeeModel(EmployeeId: 4, EmployeeName: "Swapnali", Gender: "F", BasicPay: 20000, PhoneNumber: "6755988878", Address: "Kagal", Deduction: "500", TaxablePay: "100", IncomeTax: "200", NetPay:"2000", DepartMent:"Marketing"));
            employeeDetails.Add(new EmployeeModel(EmployeeId: 5, EmployeeName: "Yugansh", Gender: "M", BasicPay: 45000, PhoneNumber: "9898887878", Address: "Kagal", Deduction: "500", TaxablePay: "100", IncomeTax: "200", NetPay:"2000", DepartMent:"Sales"));

            EmployeePayRollOperation employeePayrollOperations = new EmployeePayRollOperation();
            DateTime startDateTime = DateTime.Now; //Before Excecution
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopdateTime = DateTime.Now; //After Execution
            Console.WriteLine("Duration without Thread: " + (startDateTime - stopdateTime)); // - operator to get time duration

            DateTime startDateTime1 = DateTime.Now; //Before Excecution
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopdateTime1 = DateTime.Now; //After Execution
            Console.WriteLine("Duration without Thread: " + (startDateTime1 - stopdateTime1)); // - operator to get time duration
        }
    }
}