use PayrollService;
/*UC1-Create database*/
Create database PayrollService;
/*UC2-Create Table*/
Create table Employee_PayRoll(id int identity(1,1)primary key,EmployeeName varchar(200),Salary varchar(200),startdate DATE);
/*Extendted some columns*/
Alter table Employee_PayRoll Add PhoneNumber varchar(200);
Alter table Employee_PayRoll Add Address varchar(200);
Alter table Employee_PayRoll Add DepartMent varchar(200) NOT NULL default 'Sales';
Alter table Employee_PayRoll Alter Address SET DEFAULT 'ADS';
ALter table Employee_PayRoll RENAME Salary To BasicPay;
Alter table Employee_PayRoll Add Deduction varchar(200);
Alter table Employee_PayRoll Add TaxablePay varchar(200);
Alter table Employee_PayRoll Add IncomeTax varchar(200);
Alter table Employee_PayRoll Add NetPay varchar(200);