-- JOIN ��LEMLER�

--SELECT
--	d.Ad AS [Ders Ad�],
--	b.Ad AS [B�l�m Ad�]
--FROM Dersler d JOIN Bolumler b ON d.BolumId=b.Id
--WHERE b.Ad='Elektrik M�hendisli�i'

SELECT
*
FROM Ogrenciler o JOIN OgrenciDersler od ON o.Id=od.OgrenciId
	JOIN Dersler d ON od.DersId=d.Id