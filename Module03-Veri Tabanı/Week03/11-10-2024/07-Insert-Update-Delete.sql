/*
	C-reate(Yeni ürün oluþturma)
	R-ead(Ürün detayýný getirme, ürünleri listeleme)
	U-pdate(Ürün güncelleme)
	D-elete(Ürün silme)
	CRUD Ýþlemleri
*/
--INSERT
/*
	INSERT INTO TabloAdý(kolon1, kolon2,...) 
	VALUES
		(value1, value2,...),
		(value1, value2,...),
		...
*/
--INSERT INTO Categories(CategoryName, Description)
--VALUES ('Bilgisayar','Son teknoloji ürünü bilgisyarlar burada')

--UPDATE
/*
	UPDATE TabloAdý SET kolon1=value1, kolon2=value2,...
	WHERE koþul
*/

--UPDATE Categories SET Description='Yeni kategori açýklamasý'
--WHERE CategoryID=11

--UPDATE Categories SET Description='Yeni kategori açýklamasý'

--DELETE
/*
	DELETE FROM TabloAdý
	WHERE koþul
*/
--DELETE FROM Categories
--WHERE CategoryID=11

SELECT * FROM Categories c
WHERE c.IsDeleted=0