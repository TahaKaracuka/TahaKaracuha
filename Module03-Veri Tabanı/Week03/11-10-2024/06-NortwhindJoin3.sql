-- Hangi Bölgede Ne kadarlýk satýþ olmuþ?
--SELECT
--	r.RegionDescription AS [Bölge],
--	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Satýþ Tutarý]
--FROM OrderDetails od JOIN Orders o 
--		ON od.OrderID=o.OrderID JOIN Employees e
--			ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
--				ON e.EmployeeID=et.EmployeeID JOIN Territories t
--					ON et.TerritoryID=t.TerritoryID JOIN Region r
--						ON t.RegionID=r.RegionID
--GROUP BY r.RegionDescription

-- EN ÇOK SATIÞI YAPILAN ÝLK ÜÇ ÜRÜNÜ LÝSTELEYELÝM
--SELECT TOP(3)
--	p.ProductName AS [Ürün],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Satýþ Tutarý]
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=p.ProductID
--GROUP BY p.ProductName
--ORDER BY [Satýþ Tutarý] DESC

--EN SON SATIÞI YAPILAN 5 ÜRÜNÜ LÝSTELEYÝN
--SELECT
--	TOP(5)
--	p.ProductName,
--	o.OrderDate
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=p.ProductID JOIN Orders o
--			ON od.OrderID=o.OrderID
--ORDER BY o.OrderDate DESC

-- Hangi Bölgede Hangi Üründen Ne kadarlýk satýþ olmuþ?
--SELECT
--	r.RegionDescription AS [Bölge],
--	p.ProductName AS [Ürün],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Satýþ Tutarý]
--FROM OrderDetails od JOIN Orders o 
--		ON od.OrderID=o.OrderID JOIN Employees e
--			ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
--				ON e.EmployeeID=et.EmployeeID JOIN Territories t
--					ON et.TerritoryID=t.TerritoryID JOIN Region r
--						ON t.RegionID=r.RegionID JOIN Products p
--							ON od.ProductID=p.ProductID
--GROUP BY r.RegionDescription, p.ProductName
--ORDER BY r.RegionDescription, [Satýþ Tutarý] DESC

-- Ürünlere göre ciro?
SELECT
	p.ProductName AS [Ürün],
	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2)) AS [Satýþ Tutarý]
FROM OrderDetails od JOIN Products p
		ON od.ProductID=p.ProductID
GROUP BY p.ProductName
HAVING CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL(10,2))>=70000
ORDER BY [Satýþ Tutarý] DESC