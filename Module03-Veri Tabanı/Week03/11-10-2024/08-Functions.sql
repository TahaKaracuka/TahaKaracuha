--SELECT GETDATE()
--SELECT YEAR(GETDATE())
--SELECT MONTH(GETDATE())
--SELECT DAY(GETDATE())

--SELECT
--	e.FirstName + ' ' + e.LastName AS [Çalýþan],
--	e.BirthDate AS [Doðum Tarihi]
--FROM Employees e
----WHERE MONTH(GETDATE())=MONTH(e.BirthDate)
--WHERE MONTH('2024-1-8')=MONTH(e.BirthDate)

--SELECT
--	e.FirstName + ' ' + e.LastName AS [Çalýþan],
--	e.HireDate AS [Ýþe Baþlama Tarihi]
--FROM Employees e
----WHERE DAY(e.HireDate)<=10
--WHERE DAY(e.HireDate) BETWEEN 3 AND 10

--SELECT
--	o.OrderID AS [Id],
--	o.OrderDate AS [Sipariþ Tarihi],
--	DATEADD(DAY,5,o.OrderDate) AS [Planlanan En Geç Kargo Tarihi],
--	o.ShippedDate AS [Gerçekleþen Kargo Tarihi],
--	DATEDIFF(DAY,DATEADD(DAY,5,o.OrderDate),o.ShippedDate) AS [Gecikme]
--	--CAST(o.ShippedDate-DATEADD(DAY,5,o.OrderDate) AS int) AS [Gecikme]
--FROM Orders o
--WHERE DATEADD(DAY,5,o.OrderDate)<o.ShippedDate
--ORDER BY Gecikme DESC

--SELECT ABS(-87)
--SELECT CEILING(4.01)
--SELECT FLOOR(4.99)
--SELECT CAST(ROUND(4.6,0) AS INT)
--SELECT CAST(ROUND(4.7386,2) AS DECIMAL(10,2))
--SELECT POWER(3,2)
--SELECT POWER(2,8)

--SELECT LEN('infotech')
--SELECT UPPER('infotech')
--SELECT LOWER('INFOTECH')

--SELECT SUBSTRING('InfoTech',1,4)
SELECT REPLACE('besiktas bugun ilk macina cikiyor',' ','-')




