-- Products tablosundaki tüm kayýtlar

--SELECT
--	p.ProductID AS [Id],
--	p.ProductName AS [Ürün],
--	p.UnitPrice AS [Fiyat],
--	p.UnitsInStock AS [Stok Miktarý]
--FROM Products p

-- Maksimum, Minimum ve Ortalama Fiyatlarý ve Ürün Sayýsýný gösterelim

--SELECT
--	MAX(p.UnitPrice) AS [Maksimum Fiyat],
--	MIN(p.UnitPrice) AS [Minimum Fiyat],
--	AVG(p.UnitPrice) AS [Ortalama Fiyat],
--	COUNT(*) AS [Ürün Sayýsý]
--FROM Products p

-- Elimizdeki ürünlerin toplam DEÐERÝNÝ gösterelim.
--SELECT
--	SUM(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok Deðeri],
--	AVG(p.UnitPrice*p.UnitsInStock) AS [Ortalama Stok Deðeri]
--FROM Products p

--SELECT
--	p.ProductName,
--	UPPER(p.ProductName) AS [Büyük Harf],
--	LOWER(p.ProductName) AS [Küçük Harf]
--FROM Products p

--SELECT
--	c.ContactName,
--	REPLACE(REPLACE(LOWER(c.ContactName),' ','_'),'é','e') AS [User Name] 
--FROM Customers c

