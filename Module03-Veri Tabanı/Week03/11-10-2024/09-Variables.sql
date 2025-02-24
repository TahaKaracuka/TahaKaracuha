--DECLARE @adSoyad NVARCHAR(40)

--SET @adSoyad = 'Eray Gülüçmen'

--SELECT @adSoyad
DECLARE @categoryName NVARCHAR(50)
SET @categoryName = 'Beverages'
SELECT
	p.ProductName,
	p.UnitPrice,
	c.CategoryName
FROM Products p JOIN Categories c
		ON p.CategoryID=c.CategoryID
WHERE c.CategoryName=@categoryName