CREATE TABLE Employee
(
	Id					INT	IDENTITY(1,1),
	EmployeeCode		NVARCHAR(10) NOT NULL,
	EmployeeName		NVARCHAR(100) NOT NULL,
	Department			NVARCHAR(50) NOT NULL,
	Designation			NVARCHAR(50) NOT NULL,
	DateOfBirth			DATETIME2	NOT NULL,
	JoinDate			DATETIME2 NOT NULL,
	Salary				DECIMAL(18,2) NOT NULL,
	AddressLine			NVARCHAR(100) NULL,
	State				NVARCHAR(100) NULL,
	City				NVARCHAR(100) NULL,
	ZipCode				NVARCHAR(10) NULL,
	CONSTRAINT [PK_Employee_Id] PRIMARY KEY CLUSTERED ([Id])
)