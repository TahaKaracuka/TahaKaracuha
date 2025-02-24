/*
	C-reate(Yeni �r�n olu�turma)
	R-ead(�r�n detay�n� getirme, �r�nleri listeleme)
	U-pdate(�r�n g�ncelleme)
	D-elete(�r�n silme)
	CRUD ��lemleri
*/
--INSERT
/*
	INSERT INTO TabloAd�(kolon1, kolon2,...) 
	VALUES
		(value1, value2,...),
		(value1, value2,...),
		...
*/
--INSERT INTO Categories(CategoryName, Description)
--VALUES ('Bilgisayar','Son teknoloji �r�n� bilgisyarlar burada')

--UPDATE
/*
	UPDATE TabloAd� SET kolon1=value1, kolon2=value2,...
	WHERE ko�ul
*/

--UPDATE Categories SET Description='Yeni kategori a��klamas�'
--WHERE CategoryID=11

--UPDATE Categories SET Description='Yeni kategori a��klamas�'

--DELETE
/*
	DELETE FROM TabloAd�
	WHERE ko�ul
*/
--DELETE FROM Categories
--WHERE CategoryID=11

SELECT * FROM Categories c
WHERE c.IsDeleted=0