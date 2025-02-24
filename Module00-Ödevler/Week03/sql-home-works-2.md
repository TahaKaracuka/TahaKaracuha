
### Ödev 1: **Kütüphane Yönetim Sistemi**

Bir üniversite kütüphanesi için bir yönetim sistemi oluşturmanız isteniyor. Bu sistemde kitaplar, dergiler ve DVD'ler kaydedilecek. Ayrıca, öğrenciler kütüphaneden bu materyalleri ödünç alacaklar.

#### Yapılacaklar:

1.  **Tabloları Oluşturun:**
    
    -   `Kitaplar` tablosunu oluşturun: KitapID, KitapAdi, Yazar, YayınYılı, SayfaSayisi, ISBN.
    -   `Dergiler` tablosunu oluşturun: DergiID, DergiAdi, Yayınci, YayınTarihi, Sayı.
    -   `DVDler` tablosunu oluşturun: DVDID, DVDAdi, Yönetmen, YayınYılı, Süre.
    -   `Ogrenciler` tablosunu kullanın (mevcut `Ogrenciler` tablosu ile devam edebilir).
2.  **Veri Ekleme:**
    
    -   Kitaplar tablosuna 20 kitap ekleyin. Türkçe yazar ve kitap adlarını kullanarak örnek veriler oluşturun.
    -   Dergiler tablosuna 5 dergi ekleyin. Dergi adları ve yayıncıları Türkçe olsun.
    -   DVDler tablosuna 5 DVD ekleyin. Türkçe film isimleri ve yönetmenlerle doldurun.
3.  **Ödünç İşlemleri:**
    
    -   `OduncAlmalar` adında bir tablo oluşturun. Bu tabloda OgrenciID, KitapID, DergiID, DVDID ve OduncTarihi bilgileri yer alsın.
    -   Öğrencilerin kütüphaneden ödünç aldıkları materyalleri kaydedecek 10 örnek veri ekleyin.
4.  **Sorgular:** Aşağıdaki işlemleri yapın:
    -   Tüm kitapların adını, yazarını ve yayın yılını listeleyin. (`SELECT` ve `FROM`)
    -   Yayın yılı 2000’den sonra olan kitapların isimlerini ve yazarlarını listeleyin. (`WHERE`)
    -   Hangi öğrencinin hangi kitapları ödünç aldığını gösteren bir liste oluşturun. (`JOIN`)
    -   En fazla sayfa sayısına sahip 5 kitabı sayfa sayısına göre azalan sırayla listeleyin. (`ORDER BY` ve `LIMIT`)
    -   "Orhan Pamuk" adlı yazarın kitaplarını listeleyin. (`WHERE`)
    -   Öğrencilerin ödünç aldığı dergileri ve bu dergilerin yayıncılarını listeleyin. (`JOIN`)
    -   Henüz hiçbir materyal ödünç almayan öğrencileri listeleyin. (`LEFT JOIN` ve `IS NULL`)
    -   Her kitabın, derginin ve DVD'nin kaç kez ödünç alındığını gruplandırarak listeleyin. (`GROUP BY`)
    -   Yayın tarihi en eski olan 3 kitabı listeleyin. (`ORDER BY` ve `LIMIT`)
    -   "Ali Yılmaz" adlı öğrencinin ödünç aldığı tüm materyalleri listeleyin. (`WHERE` ve `JOIN`)


**NOT**

Araştırmanız gereken konular olacaktır. Hem elinizdeki dökümanlardan, hem internetten yapacağınız araştırmalarla ödev çalışmalarınızı destekleyiniz. 