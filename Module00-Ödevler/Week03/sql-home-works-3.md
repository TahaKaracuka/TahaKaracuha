### Ödev 2: **Personel ve Maaş Yönetimi**

Bir okulun idari işleri için bir personel ve maaş yönetim sistemi kurulması isteniyor. Personelin adı, soyadı, pozisyonu ve maaşları kaydedilecek. Ayrıca, maaş değişiklikleri kaydedilecek ve belirli raporlamalar yapılacak.

#### Yapılacaklar:

1.  **Tabloları Oluşturun:**
    
    -   `Personel` tablosunu oluşturun: PersonelID, Ad, Soyad, Pozisyon, BaslangicTarihi.
    -   `Maaslar` tablosunu oluşturun: MaasID, PersonelID, MaasMiktari, GuncellemeTarihi. (Maaşlar tabloda her maaş değişikliğinde güncellenecek, bu yüzden her güncelleme ayrı bir kayıt olacak.)
2.  **Veri Ekleme:**
    
    -   10 personel ekleyin. Personelin pozisyonları okul müdürü, öğretmen, sekreter gibi roller olsun.
    -   Her personel için başlangıç maaşlarını `Maaslar` tablosuna ekleyin. Her personel için en az bir maaş güncellemesi daha yapın.
3.  **Sorgular:** Aşağıdaki işlemleri yapın:
    -   Her personelin mevcut maaşını listeleyin (En son güncelleme tarihine göre).
    -   Tüm personelin ortalama maaşını hesaplayan bir sorgu yazın.
    -   Aynı pozisyonda çalışan personelin maaşlarını karşılaştırarak en yüksek ve en düşük maaşları getirin.
    -   Tüm personelin adını, soyadını ve pozisyonunu listeleyin. (`SELECT` ve `FROM`)
    -   Hangi pozisyonda kaç personel çalıştığını gösteren bir liste oluşturun. (`GROUP BY` ve `COUNT`)
    -   Her personelin en son maaş miktarını ve güncelleme tarihini listeleyin. (`JOIN` ve `MAX`)
    -   "Öğretmen" pozisyonunda çalışan tüm personelleri listeleyin. (`WHERE`)
    -   Tüm personelin ortalama maaşını hesaplayın. (`AVG`)
    -   En yüksek maaş alan personelin adını, soyadını ve maaşını listeleyin. (`ORDER BY` ve `LIMIT`)
    -   Bir personelin tüm maaş değişikliklerini kronolojik sırayla listeleyin. (`WHERE` ve `ORDER BY`)
    -   Aynı pozisyondaki personellerin maaşlarını karşılaştırarak en yüksek ve en düşük maaşı listeleyin. (`GROUP BY` ve `HAVING`)
    -   Son 6 ay içinde maaşı güncellenen personelleri listeleyin. (`WHERE` ve `DATEADD`)
    -   Maaşı en az iki kez güncellenmiş olan personelleri listeleyin. (`GROUP BY` ve `HAVING`) 
