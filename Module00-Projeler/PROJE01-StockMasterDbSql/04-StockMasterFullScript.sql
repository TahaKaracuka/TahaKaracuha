-- StockMaster --
USE master
GO

-- Varsa StockMaster veritaban�n� sil
IF EXISTS (SELECT * FROM sys.databases WHERE name='StockMaster')
BEGIN
	DROP DATABASE StockMaster
END
GO

-- StockMaster veritaban�n� olu�tur
CREATE DATABASE StockMaster
GO

-- StockMaster veritaban�n� se�, kullan�ma al
USE StockMaster
GO

-- Kategori tablosunu olu�tur
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Description NVARCHAR(MAX)
)
GO

-- Tedarik�i tablosunu olu�tur
CREATE TABLE Suppliers(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	ContactName NVARCHAR(100) NOT NULL,
	Phone VARCHAR(20),
	Address VARCHAR(250)
)
GO

-- �r�n tablosunu olu�tur
CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	QuantityPerUnit VARCHAR(50),
	UnitPrice DECIMAL(18,2),
	UnitsInStock INT,
	Discounted BIT,
	ReorderLevel INT,
	CategoryId INT DEFAULT 1 FOREIGN KEY REFERENCES Categories(Id) ON DELETE SET DEFAULT,
	SupplierId INT DEFAULT 1 FOREIGN KEY REFERENCES Suppliers(Id) ON DELETE SET DEFAULT
)
GO

-- Stok Hareketleri Tablosunu olu�turuyoruz
CREATE TABLE StockTransactions(
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	TransactionType VARCHAR(3) CHECK(TransactionType IN ('IN','OUT')),
	Quantity INT NOT NULL,
	TransactionDate DATETIME NOT NULL DEFAULT GETDATE()
)
GO

-- Kullan�c� tablosunu olu�turuyoruz
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	UserName VARCHAR(50) NOT NULL,
	Password VARCHAR(100) NOT NULL,
	Role VARCHAR(50)
)
GO

-- Kategoriler Tablosuna Veri Ekleme
INSERT INTO Categories (Name, Description)
VALUES 
	('Genel','Kategorisiz �r�nler burada'),
    ('Elektronik', 'Elektronik cihazlar ve aksesuarlar'), 
    ('Ofis Malzemeleri', 'Kalem, ka��t, yaz�c� gibi malzemeler'),
    ('Mutfak Gere�leri', 'B��aklar, tencereler, mutfak aletleri'),
    ('Kitaplar', 'Her t�rden kitaplar ve bas�l� yay�nlar'),
    ('Giyim', 'Her t�rl� giysi ve aksesuar'),
    ('Kozmetik', 'Cilt bak�m ve g�zellik �r�nleri'),
    ('Spor E�yalar�', 'Spor ve a��k hava etkinlikleri i�in malzemeler'),
    ('Ev E�yalar�', 'Evde kullan�lan e�yalar'),
    ('Hobi �r�nleri', 'Hobi ve e�lence ile ilgili �r�nler'),
    ('Oyunlar', 'Oyun ve e�lence malzemeleri');
GO

-- Tedarik�iler Tablosuna Veri Ekleme
INSERT INTO Suppliers (Name, ContactName, Phone, Address)
VALUES 
	('Genel','Genel','0000','Tedarik�i belli de�il'),
    ('ABC Elektronik', 'Ali Y�lmaz', '555-1234', '�stanbul, T�rkiye'),
    ('XYZ Ofis', 'Mehmet Kaya', '555-5678', 'Ankara, T�rkiye'),
    ('Gourmet Mutfak', 'Ay�e Demir', '555-8765', '�zmir, T�rkiye'),
    ('Kitap D�nyas�', 'Deniz Y�lmaz', '555-4321', 'Bursa, T�rkiye')
GO

-- �r�nler Tablosuna Veri Ekleme
-- Elektronik Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Laptop', 1, 1, '1 adet', 15000.00, 50, 10, 0),
    ('Ak�ll� Telefon', 1, 1, '1 adet', 7000.00, 30, 5, 0),
    ('Kulakl�k', 1, 1, '1 adet', 300.00, 100, 20, 0),
    ('Tablet', 1, 1, '1 adet', 4000.00, 15, 7, 0)
GO

-- Ofis Malzemeleri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Yaz�c�', 2, 2, '1 adet', 500.00, 100, 20, 0),
    ('Kalem', 2, 2, '10 adet', 20.00, 200, 50, 0),
    ('Defter', 2, 2, '5 adet', 15.00, 150, 25, 0),
    ('Dosya', 2, 2, '10 adet', 50.00, 80, 15, 0)
GO

-- Mutfak Gere�leri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Mikser', 3, 3, '1 adet', 200.00, 75, 15, 0),
    ('Tencere Seti', 3, 3, '5 adet', 350.00, 30, 5, 0),
    ('B��ak Seti', 3, 3, '3 adet', 150.00, 60, 10, 0),
    ('Kesme Tahtas�', 3, 3, '1 adet', 25.00, 90, 12, 0)
GO

-- Kitaplar Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Roman Kitap', 4, 4, '1 adet', 30.00, 200, 50, 0),
    ('Bilim Kurgu Kitab�', 4, 4, '1 adet', 45.00, 150, 30, 0),
    ('Ders Kitab�', 4, 4, '1 adet', 60.00, 100, 20, 0),
    ('Kendi Kendine ��renme', 4, 4, '1 adet', 25.00, 250, 60, 0)
GO

-- Giyim Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Ti��rt', 5, 1, '1 adet', 50.00, 100, 20, 0),
    ('Pantolon', 5, 1, '1 adet', 150.00, 80, 15, 0),
    ('Ceket', 5, 1, '1 adet', 200.00, 50, 10, 0),
    ('Kazak', 5, 1, '1 adet', 80.00, 60, 12, 0)
GO

-- Kozmetik Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Nemlendirici Krem', 6, 2, '1 adet', 100.00, 120, 25, 0),
    ('Dudak Balm�', 6, 2, '1 adet', 30.00, 200, 30, 0),
    ('Parf�m', 6, 2, '1 adet', 250.00, 50, 10, 0),
    ('Makyaj F�r�as�', 6, 2, '1 adet', 75.00, 70, 12, 0)
GO

-- Spor E�yalar� Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Dumbbell Seti', 7, 3, '2 adet', 200.00, 30, 5, 0),
    ('Yoga Mat�', 7, 3, '1 adet', 75.00, 50, 10, 0),
    ('Ko�u Band�', 7, 3, '1 adet', 2500.00, 10, 2, 0),
    ('Bisiklet', 7, 3, '1 adet', 1500.00, 20, 4, 0)
GO

-- Ev E�yalar� Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Koltuk Tak�m�', 8, 4, '1 tak�m', 5000.00, 10, 2, 0),
    ('Masa', 8, 4, '1 adet', 800.00, 15, 3, 0),
    ('Sandalye', 8, 4, '4 adet', 400.00, 25, 5, 0),
    ('Lamba', 8, 4, '1 adet', 150.00, 30, 6, 0)
GO

-- Hobi �r�nleri Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Resim Seti', 9, 1, '1 set', 120.00, 40, 8, 0),
    ('Maket Seti', 9, 1, '1 set', 150.00, 20, 4, 0),
    ('Yapboz', 9, 1, '1 adet', 30.00, 60, 12, 0),
    ('M�zik Aleti', 9, 1, '1 adet', 500.00, 15, 3, 0)
GO

-- Oyunlar Kategorisi
INSERT INTO Products (Name, CategoryId, SupplierId, QuantityPerUnit, UnitPrice, UnitsInStock, ReorderLevel, Discounted)
VALUES 
    ('Masa Oyunu', 10, 2, '1 adet', 100.00, 50, 10, 0),
    ('Video Oyunu', 10, 2, '1 adet', 300.00, 20, 5, 0),
    ('Kart Oyunu', 10, 2, '1 adet', 50.00, 70, 15, 0),
    ('Bulmaca', 10, 2, '1 adet', 40.00, 80, 20, 0)
GO

-- Stok Hareketleri Veri Ekleme
INSERT INTO StockTransactions (ProductId, TransactionType, Quantity)
VALUES 
    (1, 'IN', 50),
    (2, 'IN', 100),
    (1, 'OUT', 10),
    (3, 'IN', 75),
    (4, 'IN', 30),
    (5, 'IN', 200),
    (6, 'OUT', 30),
    (7, 'IN', 20),
    (3, 'OUT', 5)
GO

-- Yeni �r�n Ekleme
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
		PRINT 'Stok seviyesi d���k, yeniden sipari� ver!'
	END
	ELSE
	BEGIN
		PRINT 'Stok seviyesi yeterli'
	END
END
GO

-- Kontroll� �ekilde Stok ��k��� --
CREATE PROCEDURE ProductExit
	@productId INT,
	@quantity INT
AS
BEGIN
	DECLARE @currentStock INT

	SELECT @currentStock = p.UnitsInStock
	FROM Products p
	WHERE p.Id=@productId

	IF @currentStock>=@quantity
	BEGIN
		INSERT INTO StockTransactions(ProductId,TransactionType,Quantity)
		VALUES (@productId,'OUT',@quantity)
		
		UPDATE Products SET UnitsInStock=UnitsInStock-@quantity
		WHERE Id=@productId

		SELECT 1 AS Result
	END
	ELSE
	BEGIN
		SELECT 0 AS Result
	END
END
GO

CREATE PROCEDURE ProductIn
	@productId INT,
	@quantity INT
AS
BEGIN
	INSERT INTO StockTransactions(ProductId,TransactionType,Quantity)
	VALUES (@productId, 'IN',  @quantity)
	IF @@ROWCOUNT>0
	BEGIN
		UPDATE Products SET UnitsInStock=UnitsInStock+@quantity
		WHERE Id=@productId

		SELECT 1 AS Result
	END
	ELSE
	BEGIN
		SELECT 0 AS Result
	END
END



