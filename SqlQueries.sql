use PayrollService;
/*UC1-Create database*/
Create database PayrollService;
/*UC2-Create Table*/
/*Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);*/
/*UC3-Insert Data*/
Insert into Employee_PayRoll(EmployeeName,Salary,startdate,Gender)values('Sangram',25000,'2022/1/1','M');
/*UC4-Retrive Data*/
Select * from Employee_PayRoll;
/*UC5-Retrive Data from particular condition*/
/*select Salary of particular employee*/
select Salary from Employee_PayRoll where EmployeeName='Rajashri';
select * from Employee_PayRoll WHERE startdate BETWEEN CAST('2021-01-01' AS DATE)and CAST('2021-02-03' AS DATE);
/*UC6*/
/*Alter table*/
Alter table Employee_PayRoll Add Gender Varchar(100);
/*update table*/
update Employee_PayRoll set Gender='F' Where EmployeeName='Sejal' or  EmployeeName='Priyanka';
/*UC7*/
select Sum(Salary) as SalaryTotal from Employee_PayRoll where Gender='M' group by Gender;
select Min(Salary) as SalaryTotal from Employee_PayRoll where Gender='F' group by Gender;
select Max(Salary) as SalaryTotal from Employee_PayRoll where Gender='M' group by Gender;
select Avg(Salary) as SalaryTotal from Employee_PayRoll where Gender='M' group by Gender;
select Count(Salary) as SalaryTotal from Employee_PayRoll where Gender='M' group by Gender;
/*UC8*/
Alter table Employee_PayRoll Add PhoneNumber varchar(200);
Alter table Employee_PayRoll Add Address varchar(200);
Alter table Employee_PayRoll Add DepartMent varchar(200) NOT NULL;
Alter table Employee_PayRoll Alter Address SET DEFAULT 'ADS';
/*UC9*/
ALter table Employee_PayRoll RENAME Salary To BasicPay;
Alter table Employee_PayRoll Add Deduction varchar(200);
Alter table Employee_PayRoll Add TaxablePay varchar(200);
Alter table Employee_PayRoll Add IncomeTax varchar(200);
Alter table Employee_PayRoll Add NetPay varchar(200);