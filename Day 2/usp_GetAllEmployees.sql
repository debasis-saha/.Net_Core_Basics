CREATE PROCEDURE usp_GetAllEmployees
(
	@p_EmployeeId		NVARCHAR = 0
)
AS
BEGIN
   SET NOCOUNT ON;
   IF @p_EmployeeId =0
	BEGIN
		SELECT * FROM Employee
	END
	ELSE
	BEGIN
		SELECT * FROM Employee WHERE Id= @p_EmployeeId
	END
END
GO
