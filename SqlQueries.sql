/*Create database*/
Create database PayrollService;
/*Create Table*/
Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);
/*Insert Data*/
Insert into Employee_PayRoll(EmployeeName,Salary,startdate)values('Rajashri','35000','2021/2/3');
/*Retrive Data*/
Select * from Employee_PayRoll;