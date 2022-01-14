Alter PROCEDURE SpEmployeePayroll 
(
	@EmployeeName varchar(200),
	@Gender varchar(200),
	@BasicPay int,	
	@PhoneNumber varchar(200),
	@Address varchar(200),
	@Deduction varchar(200),	
	@TaxablePay	 varchar(200),
	@IncomeTax varchar(200),	
	@NetPay	varchar(200),
	@DepartMent varchar(200)
)
AS
BEGIN
insert into Employee_PayRoll values(@EmployeeName,@Gender,@BasicPay,@PhoneNumber,@Address,@Deduction,
@TaxablePay,@IncomeTax,@NetPay,@DepartMent)
SET NOCOUNT ON;
SELECT EmployeeName,Gender,BasicPay,PhoneNumber,Address,Deduction,
TaxablePay,IncomeTax,NetPay,DepartMent FROM Employee_PayRoll;
END
GO
/****Update Stored procedure*/
Alter PROCEDURE SpEmployeePayroll_Update
(
	@EmployeeName varchar(200),
	@Gender varchar(200),
	@BasicPay int,	
	@PhoneNumber varchar(200),
	@Address varchar(200),
	@Deduction varchar(200),	
	@TaxablePay	 varchar(200),
	@IncomeTax varchar(200),	
	@NetPay	varchar(200),
	@DepartMent varchar(200)
)
AS
BEGIN
update Employee_PayRoll set EmployeeName=@EmployeeName,Gender=@Gender,BasicPay=@BasicPay,
PhoneNumber=@PhoneNumber,Address=@Address,Deduction=@Deduction,
TaxablePay=@TaxablePay,IncomeTax=@IncomeTax,NetPay=@NetPay,DepartMent=@DepartMent where EmployeeName=@EmployeeName
SET NOCOUNT ON;
SELECT EmployeeName,Gender,BasicPay,PhoneNumber,Address,Deduction,
TaxablePay,IncomeTax,NetPay,DepartMent FROM Employee_PayRoll;
END
GO
/****Delete Stored Procedure****/
Create PROCEDURE SpEmployeePayroll_Delete
(
	@EmployeeName varchar(200)
)
AS
BEGIN
delete from Employee_PayRoll where EmployeeName=@EmployeeName
SET NOCOUNT ON;
SELECT EmployeeName,Gender,BasicPay,PhoneNumber,Address,Deduction,
TaxablePay,IncomeTax,NetPay,DepartMent FROM Employee_PayRoll;
END
GO