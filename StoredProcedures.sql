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