// See https://aka.ms/new-console-template for more information
using PayRollService;

Console.WriteLine("*************PayRollService******************");
bool status = true;
while (status)
{
    Console.WriteLine("Select option\n1)Create Database\n2)Create Table");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            EmployeeData.Create_Database();
            break;
        case 2:
            EmployeeData.CreateTables();
            break;
        default:
            Console.WriteLine("Wrong Choice");
            break;
    }
}