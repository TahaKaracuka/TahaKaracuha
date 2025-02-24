-- JOIN ÝÞLEMLERÝ

--SELECT
--	d.Ad AS [Ders Adý],
--	b.Ad AS [Bölüm Adý]
--FROM Dersler d JOIN Bolumler b ON d.BolumId=b.Id
--WHERE b.Ad='Elektrik Mühendisliði'

SELECT
*
FROM Ogrenciler o JOIN OgrenciDersler od ON o.Id=od.OgrenciId
	JOIN Dersler d ON od.DersId=d.Id