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
	('Bilgisayar M�hendisli�i'),
	('Elektrik M�hendisli�i'),
	('Makine M�hendisli�i')
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
	('Veritaban� Y�netimi',4,1),
	('Algoritmalar',3,1),

	('Devre Teorisi',8,2),
	('Elektrik Devreleri',6,2),
	('Otomatik Kumanda',3,2),
	('Temel Elektronik',4,2),

	('Makine M�hendisli�ine Giri�',4,3),
	('Termodinamik',6,3),
	('Ak��kanlar Mekani�i',8,3),
	('Malzeme Bilimi',4,3),
	('Mesleki �ngilizce',4,3)
GO

CREATE TABLE Ogrenciler(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(50) NOT NULL,
	Soyad NVARCHAR(50) NOT NULL,
	DogumTarihi DATE NULL,
	BolumId INT NOT NULL,
	FOREIGN KEY(BolumId) REFERENCES Bolumler(Id)
)
GO

INSERT INTO Ogrenciler(BolumId, Ad, Soyad)
VALUES
	(1,'Ali','Cabbar'),
	(1,'Sezen','Kara'),
	(1,'Mehmet','Kendir'),

	(2,'Cavit','Tutan'),
	(2,'Kemal','Kanatan'),
	(2,'Ceyda','D�men'),
	(2,'Ay�en', 'Gruda'),

	(3,'O�uz','Kanayan')
GO

-- Sinem Ko�ak ad�nda, 3 numaral� b�l�mde okuyan, 19.07.1999 do�umlu ��renciyi ekleyin.
INSERT INTO Ogrenciler(BolumId,Ad,Soyad,DogumTarihi)
VALUES
	(3,'Sinem','Ko�ak','1999-07-19')
GO

CREATE TABLE OgrenciDersler(
	OgrenciId INT NOT NULL,
	DersId INT NOT NULL,
	PRIMARY KEY(OgrenciId,DersId),
	FOREIGN KEY(OgrenciId) REFERENCES Ogrenciler(Id),
	FOREIGN KEY(DersId) REFERENCES Dersler(Id)
)
GO

--Bilgisayar b�l�m� ��rencilerine ders at�yoruz.
--��renciler: 1-2-3
--Dersler: 1-2-3
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
	(1,1),(1,3),
	(2,1),(2,2),(2,3),
	(3,3)
GO

--Elektrik b�l�m� ��rencilerine ders at�yoruz
--��renciler: 4-5-6-7
--Dersler:4-5-6-7
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
	(4,4),(4,7),
	(5,5),(5,6),(5,7),
	(6,4),(6,5),(6,6),(6,7),
	(7,6),(7,7)

--Makine b�l�m� ��rencilerine ders at�yoruz
--��renciler: 8-9
--Dersler:8-9-10-11-12
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
	(8,8),(8,9),(8,10),(8,11),
	(9,10),(9,12)
GO

USE master
GO