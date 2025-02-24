--CREATE FUNCTION GetFullName(@employeeId INT)
--RETURNS NVARCHAR(100) AS
--BEGIN
--	DECLARE @fullName NVARCHAR(100)
--	SELECT @fullName=
--				e.TitleOfCourtesy + ' ' +
--				e.FirstName + ' ' +
--				e.LastName
--			FROM Employees e
--			WHERE e.EmployeeID=@employeeId
--	RETURN @fullName
--END


SELECT 
	dbo.GetFullName(e.EmployeeID) AS [Çalýþan],
	e.City AS [Þehir]
FROM Employees e