/*UC1-Create database*/
Create database PayrollService;
/*UC2-Create Table*/
Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);
/*UC3-Insert Data*/
Insert into Employee_PayRoll(EmployeeName,Salary,startdate)values('Rajashri','35000','2021/2/3');
/*UC4-Retrive Data*/
Select * from Employee_PayRoll;
/*UC5-Retrive Data from particular condition*/
/*select Salary of particular employee*/
select Salary from Employee_PayRoll where EmployeeName='Rajashri';
select * from Employee_PayRoll WHERE startdate BETWEEN CAST('2021-01-01' AS DATE)and CAST('2021-02-03' AS DATE);