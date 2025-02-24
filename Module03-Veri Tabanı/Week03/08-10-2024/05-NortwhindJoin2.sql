-- JOIN: Sql'de birden fazla tabloyu birleþtirebilmek için kullandýðýmýz yapýya JOIN diyoruz. JOIN, ilgili tablolarýn ilgili alanlarý üzerinden iliþki kurarak gerekleþtirilir.

-- Join Türleri:
-- 1) (INNER) JOIN: Her iki tablodaki EÞLEÞEN DEÐERLERE SAHÝP KAYITLARI döndürür.
-- 2) LEFT JOIN: Sol taraftaki tüm kayýtlarý, sað taraftaki ise eþleþen kayýtlarý döndürür.
-- 3) RIGHT JOIN: Sað taraftaki tüm kayýtlarý, sol taraftaki ise eþleþen kayýtlarý döndürür.
-- 4) OUTER (FULL) JOIN: Her iki taraftaki tüm kayýtlarý getirir.

--SELECT *
--FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID
--FROM Categories c INNER JOIN Products p ON c.CategoryID=p.CategoryID


--SELECT *
--FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID

--SELECT *
--FROM Categories c RIGHT JOIN Products p ON c.CategoryID=p.CategoryID

--SELECT *
--FROM Categories c  FULL JOIN Products p ON c.CategoryID=p.CategoryID

-- Hangi sipariþ, hangi çalýþan tarafýndan, hangi müþteri için verilmiþtir?
-- SipariþId			Sipariþ Tarihi		Çalýþan			Müþteri
-- 10240				2000-5-19			Eray Gülüçmen	Engin Niyazi Ergül

--SELECT
--	o.OrderID AS [Sipariþ Id],
--	o.OrderDate AS [Sipariþ Tarihi],
--	e.FirstName + ' ' + e.LastName AS [Çalýþan],
--	c.CompanyName AS [Müþteri]
--FROM Orders o 
--		JOIN Employees e ON o.EmployeeID=e.EmployeeID
--			JOIN Customers c ON o.CustomerID=c.CustomerID


-- Bugüne kadar hangi ülkelere kargo gönderimi yapmýþýz?

--SELECT DISTINCT o.ShipCountry
--FROM Orders o

-- Bugüne kadar hangi ülkelere kaç kez kargo gönderimi yapmýþýz?

--SELECT
--	o.ShipCountry AS [Ülke],
--	COUNT(*) AS [Kargo Gönderim Sayýsý],
--	SUM(o.Freight) AS [Kargo Masrafý]
--FROM Orders o
--GROUP BY o.ShipCountry
----ORDER BY o.ShipCountry ASC
--ORDER BY [Kargo Gönderim Sayýsý] DESC, [Kargo Masrafý] DESC

-- Kategorilere göre toplam stok miktarýný gösterelim
--SELECT 
--	c.CategoryName AS [Kategori],
--	SUM(p.UnitsInStock) AS [Toplam Stok Miktarý]
--FROM Categories c 
--		JOIN Products p ON c.CategoryID=p.CategoryID
--GROUP BY c.CategoryName


-- Bugüne kadar ne kadarlýk satýþ yapmýþýz? (Ciro)
--SELECT 
--	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
--FROM OrderDetails od
-- ÖDEV: Sonucu ondalýklý kýsmý 2 basamak gösterecek þekilde nasýl bir sorgu yazarýz?


-- Hangi ürün ne kadarlýk satýlmýþ?
SELECT 
	p.ProductName AS [Ürün],
	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
FROM OrderDetails od
	JOIN Products p ON od.ProductID=p.ProductID
GROUP BY p.ProductName

-- Hangi Bölgede Ne kadarlýk satýlmýþ?
