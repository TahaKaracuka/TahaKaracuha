-- Products tablosundaki t�m kay�tlar

--SELECT
--	p.ProductID AS [Id],
--	p.ProductName AS [�r�n],
--	p.UnitPrice AS [Fiyat],
--	p.UnitsInStock AS [Stok Miktar�]
--FROM Products p

-- Maksimum, Minimum ve Ortalama Fiyatlar� ve �r�n Say�s�n� g�sterelim

--SELECT
--	MAX(p.UnitPrice) AS [Maksimum Fiyat],
--	MIN(p.UnitPrice) AS [Minimum Fiyat],
--	AVG(p.UnitPrice) AS [Ortalama Fiyat],
--	COUNT(*) AS [�r�n Say�s�]
--FROM Products p

-- Elimizdeki �r�nlerin toplam DE�ER�N� g�sterelim.
--SELECT
--	SUM(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok De�eri],
--	AVG(p.UnitPrice*p.UnitsInStock) AS [Ortalama Stok De�eri]
--FROM Products p

--SELECT
--	p.ProductName,
--	UPPER(p.ProductName) AS [B�y�k Harf],
--	LOWER(p.ProductName) AS [K���k Harf]
--FROM Products p

--SELECT
--	c.ContactName,
--	REPLACE(REPLACE(LOWER(c.ContactName),' ','_'),'�','e') AS [User Name] 
--FROM Customers c

