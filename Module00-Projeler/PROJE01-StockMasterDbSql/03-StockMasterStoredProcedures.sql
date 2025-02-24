-- Yeni Ürün Ekleme
CREATE PROCEDURE AddNewProduct
	@Name NVARCHAR(100),
	@CategoryId INT,
	@SupplierId INT,
	@QuantityPerUnit VARCHAR(50),
	@UnitPrice DECIMAL(18,2),
	@UnitsInStock INT,
	@Discounted BIT,
	@ReorderLevel INT
AS
BEGIN
	INSERT INTO Products(Name,CategoryId,SupplierId,QuantityPerUnit,UnitPrice,UnitsInStock,ReorderLevel,Discounted)
	VALUES
	(@Name,@CategoryId,@SupplierId,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@ReorderLevel,@Discounted)
END
GO

-- Stok Seviyesini Kontrol Etme
CREATE PROCEDURE CheckStockLevel
	@productId INT
AS
BEGIN
	DECLARE @stock INT
	DECLARE @reorderLevel INT
	SELECT @stock = UnitsInStock FROM Products WHERE Id=@productId
	SELECT @reorderLevel = ReorderLevel FROM Products WHERE Id=@productId
	
	IF @stock<=@reorderLevel
	BEGIN
		PRINT 'Stok seviyesi düþük, yeniden sipariþ ver!'
	END
	ELSE
	BEGIN
		PRINT 'Stok seviyesi yeterli'
	END
END