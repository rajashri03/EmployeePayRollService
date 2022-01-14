// See https://aka.ms/new-console-template for more information
using PayRollService;

Console.WriteLine("*************PayRollService******************");
bool status = true;
EmployeeModel emp = new EmployeeModel();
EmployeeData empdata = new EmployeeData();
while (status)
{
    Console.WriteLine("Select option\n1)Create Database\n2)Create Table\n3)Insert Data\n4)Update Record");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            EmployeeData.Create_Database();
            break;
        case 2:
            EmployeeData.CreateTables();
            break;
        case 3:
            emp.EmployeeName = "Rajashri";
            emp.Gender = "F";
            emp.BasicPay = 25000;
            emp.PhoneNumber = "9878987898";
            emp.Address = "Kagal";
            emp.Deduction = "1000";
            emp.TaxablePay = "2000";
            emp.IncomeTax = "2000";
            emp.NetPay = "1000";
            emp.DepartMent = "Sales";
            empdata.AddEmployee(emp);
            Console.WriteLine("Record inserted");
            break;
        case 4:
            emp.EmployeeName = "Ram";
            emp.Gender = "M";
            emp.BasicPay = 45000;
            emp.PhoneNumber = "9448987898";
            emp.Address = "Kolhapur";
            emp.Deduction = "2000";
            emp.TaxablePay = "1000";
            emp.IncomeTax = "1000";
            emp.NetPay = "500";
            emp.DepartMent = "IT";
            empdata.UpdateEmployee(emp);
            Console.WriteLine("Record Updated");
            break;
        default:
            Console.WriteLine("Wrong Choice");
            break;
    }
}