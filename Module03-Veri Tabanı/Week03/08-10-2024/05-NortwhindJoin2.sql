-- JOIN: Sql'de birden fazla tabloyu birle�tirebilmek i�in kulland���m�z yap�ya JOIN diyoruz. JOIN, ilgili tablolar�n ilgili alanlar� �zerinden ili�ki kurarak gerekle�tirilir.

-- Join T�rleri:
-- 1) (INNER) JOIN: Her iki tablodaki E�LE�EN DE�ERLERE SAH�P KAYITLARI d�nd�r�r.
-- 2) LEFT JOIN: Sol taraftaki t�m kay�tlar�, sa� taraftaki ise e�le�en kay�tlar� d�nd�r�r.
-- 3) RIGHT JOIN: Sa� taraftaki t�m kay�tlar�, sol taraftaki ise e�le�en kay�tlar� d�nd�r�r.
-- 4) OUTER (FULL) JOIN: Her iki taraftaki t�m kay�tlar� getirir.

--SELECT *
--FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID
--FROM Categories c INNER JOIN Products p ON c.CategoryID=p.CategoryID


--SELECT *
--FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID

--SELECT *
--FROM Categories c RIGHT JOIN Products p ON c.CategoryID=p.CategoryID

--SELECT *
--FROM Categories c  FULL JOIN Products p ON c.CategoryID=p.CategoryID

-- Hangi sipari�, hangi �al��an taraf�ndan, hangi m��teri i�in verilmi�tir?
-- Sipari�Id			Sipari� Tarihi		�al��an			M��teri
-- 10240				2000-5-19			Eray G�l��men	Engin Niyazi Erg�l

--SELECT
--	o.OrderID AS [Sipari� Id],
--	o.OrderDate AS [Sipari� Tarihi],
--	e.FirstName + ' ' + e.LastName AS [�al��an],
--	c.CompanyName AS [M��teri]
--FROM Orders o 
--		JOIN Employees e ON o.EmployeeID=e.EmployeeID
--			JOIN Customers c ON o.CustomerID=c.CustomerID


-- Bug�ne kadar hangi �lkelere kargo g�nderimi yapm���z?

--SELECT DISTINCT o.ShipCountry
--FROM Orders o

-- Bug�ne kadar hangi �lkelere ka� kez kargo g�nderimi yapm���z?

--SELECT
--	o.ShipCountry AS [�lke],
--	COUNT(*) AS [Kargo G�nderim Say�s�],
--	SUM(o.Freight) AS [Kargo Masraf�]
--FROM Orders o
--GROUP BY o.ShipCountry
----ORDER BY o.ShipCountry ASC
--ORDER BY [Kargo G�nderim Say�s�] DESC, [Kargo Masraf�] DESC

-- Kategorilere g�re toplam stok miktar�n� g�sterelim
--SELECT 
--	c.CategoryName AS [Kategori],
--	SUM(p.UnitsInStock) AS [Toplam Stok Miktar�]
--FROM Categories c 
--		JOIN Products p ON c.CategoryID=p.CategoryID
--GROUP BY c.CategoryName


-- Bug�ne kadar ne kadarl�k sat�� yapm���z? (Ciro)
--SELECT 
--	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
--FROM OrderDetails od
-- �DEV: Sonucu ondal�kl� k�sm� 2 basamak g�sterecek �ekilde nas�l bir sorgu yazar�z?


-- Hangi �r�n ne kadarl�k sat�lm��?
SELECT 
	p.ProductName AS [�r�n],
	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
FROM OrderDetails od
	JOIN Products p ON od.ProductID=p.ProductID
GROUP BY p.ProductName

-- Hangi B�lgede Ne kadarl�k sat�lm��?
