-- Hangi B�lgede Ne kadarl�k sat�� olmu�?
--SELECT
--	r.RegionDescription AS [B�lge],
--	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Sat�� Tutar�]
--FROM OrderDetails od JOIN Orders o 
--		ON od.OrderID=o.OrderID JOIN Employees e
--			ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
--				ON e.EmployeeID=et.EmployeeID JOIN Territories t
--					ON et.TerritoryID=t.TerritoryID JOIN Region r
--						ON t.RegionID=r.RegionID
--GROUP BY r.RegionDescription

-- EN �OK SATI�I YAPILAN �LK �� �R�N� L�STELEYEL�M
--SELECT TOP(3)
--	p.ProductName AS [�r�n],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Sat�� Tutar�]
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=p.ProductID
--GROUP BY p.ProductName
--ORDER BY [Sat�� Tutar�] DESC

--EN SON SATI�I YAPILAN 5 �R�N� L�STELEY�N
--SELECT
--	TOP(5)
--	p.ProductName,
--	o.OrderDate
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=p.ProductID JOIN Orders o
--			ON od.OrderID=o.OrderID
--ORDER BY o.OrderDate DESC

-- Hangi B�lgede Hangi �r�nden Ne kadarl�k sat�� olmu�?
--SELECT
--	r.RegionDescription AS [B�lge],
--	p.ProductName AS [�r�n],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Sat�� Tutar�]
--FROM OrderDetails od JOIN Orders o 
--		ON od.OrderID=o.OrderID JOIN Employees e
--			ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
--				ON e.EmployeeID=et.EmployeeID JOIN Territories t
--					ON et.TerritoryID=t.TerritoryID JOIN Region r
--						ON t.RegionID=r.RegionID JOIN Products p
--							ON od.ProductID=p.ProductID
--GROUP BY r.RegionDescription, p.ProductName
--ORDER BY r.RegionDescription, [Sat�� Tutar�] DESC

-- �r�nlere g�re ciro?
SELECT
	p.ProductName AS [�r�n],
	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Sat�� Tutar�]
FROM OrderDetails od JOIN Products p
		ON od.ProductID=p.ProductID
GROUP BY p.ProductName
HAVING CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2))>=70000
ORDER BY [Sat�� Tutar�] DESC