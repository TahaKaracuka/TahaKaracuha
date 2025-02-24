# Okul veri tabanı ile ilgili aşağıdaki işlemleri yapın
-   **Bölüm Bazında Not Ortalaması:** Her bölümdeki tüm öğrencilerin aldıkları derslerden elde ettikleri notların ortalamasını bulun. Her bir bölüm için ortalama notu listeleyin.
    
    -   İpucu: `AVG` fonksiyonu ve `GROUP BY` kullanarak sorgu yazın.
-   **En Yüksek Notu Alan Öğrenciyi Bulma:** Tüm bölümler arasından en yüksek notu alan öğrenciyi ve hangi dersten bu notu aldığını listeleyin. Öğrencinin adını, soyadını, bölümünü, dersi ve notunu sonuç olarak getirin.
    
    -   İpucu: `MAX` ve `JOIN` kullanarak öğrenci, ders ve not bilgilerini birleştirin.
-   **Başarısız Öğrencilerin Listesi:** Notu 50'nin altında olan tüm öğrencilerin listesini oluşturun. Öğrencinin adı, soyadı, bölümü, dersi ve aldığı notu gösteren bir sorgu yazın.
    
    -   İpucu: `WHERE` ile not filtresi ekleyin ve birden fazla tabloyu `JOIN` ile birleştirin.
-   **Ogretmenler Tablosunu Oluşturma:** Öğretmenlerin ID, Ad, Soyad ve Bölüm bilgilerini tutan yeni bir tablo oluşturun.
    
    -   `Ogretmenler` tablosunu oluşturun ve öğretim üyelerinin bilgilerini ekleyin (en az 5 öğretmen ekleyin).
    -   `OgretmenID`, `Ad`, `Soyad`, `BolumID` alanlarını içersin.
-   **OgretmenDersler Tablosunu Oluşturma:** Her öğretmenin hangi dersleri verdiğini kaydetmek için yeni bir tablo oluşturun. Bu tabloda, öğretmenlerin ID'leri ve verdikleri derslerin ID'leri yer alsın.
    
    -   `OgretmenDersler` tablosunu oluşturun. `OgretmenID` ve `DersID` bilgilerini içersin.
    -   5 farklı öğretim üyesine, en az 2 farklı ders atayın.
-   **Sorgulama:** Her öğretmenin verdiği dersleri ve bu derslere kayıtlı olan öğrencilerin listesini getiren bir sorgu yazın. Sorgu sonuçları, öğretmen adı, ders adı ve öğrenci adını içermelidir.


**NOT**

Araştırmanız gereken konular olacaktır. Hem elinizdeki dökümanlardan, hem internetten yapacağınız araştırmalarla ödev çalışmalarınızı destekleyiniz. 