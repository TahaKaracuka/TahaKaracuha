USE master
GO

DROP DATABASE IF EXISTS OkulDb
GO

CREATE DATABASE OkulDb
GO

USE OkulDb
GO

CREATE TABLE Bolumler(
	Id INT PRIMARY KEY IDENTITY(1,1), 
	Ad NVARCHAR(50) NOT NULL,
)
GO

INSERT INTO Bolumler(Ad)
VALUES
	('Bilgisayar Mühendisliği'),
	('Elektrik Mühendisliği'),
	('Makine Mühendisliği')
GO

CREATE TABLE Dersler(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(100) NOT NULL,
	Kredi TINYINT NOT NULL,
	BolumId INT NOT NULL,
	FOREIGN KEY(BolumId) REFERENCES Bolumler(Id)
)
GO

INSERT INTO Dersler(Ad,Kredi,BolumId)
VALUES
	('Programlama Dilleri',6,1),
	('Veritabanı Yönetimi',4,1),
	('Algoritmalar',3,1),

	('Devre Teorisi',8,2),
	('Elektrik Devreleri',6,2),
	('Otomatik Kumanda',3,2),
	('Temel Elektronik',4,2),

	('Makine Mühendisliğine Giriş',4,3),
	('Termodinamik',6,3),
	('Akışkanlar Mekaniği',8,3),
	('Malzeme Bilimi',4,3),
	('Mesleki İngilizce',4,3)
