use PayrollService;
/*UC1-Create database*/
Create database PayrollService;
/*UC2-Create Table*/
Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);