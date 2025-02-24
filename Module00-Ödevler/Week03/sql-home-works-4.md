### Ödev 3: **Öğrenci Kulüpleri Yönetimi**

Bir okulda öğrencilerin katıldıkları kulüpler ve bu kulüplerdeki rollerini yönetmek için bir sistem kurulacak.

#### Yapılacaklar:

1.  **Tabloları Oluşturun:**
    
    -   `Kulüpler` tablosunu oluşturun: KulupID, KulupAdi, KurulusYili.
    -   `OgrenciKulup` tablosunu oluşturun: OgrenciID, KulupID, Rol (Başkan, Üye, Sekreter vb.), KatilimTarihi.
2.  **Veri Ekleme:**
    
    -   5 kulüp oluşturun (örneğin: Tiyatro Kulübü, Müzik Kulübü, Spor Kulübü vb.).
    -   En az 15
    -   Her kulübe en az 3 öğrenci ekleyin. Öğrencilerin farklı rollerde yer almasını sağlayın.
3.  **Sorgular:** Aşağıdaki işlemleri yapın:

      -  Tüm kulüp üyelerinin adlarını, soyadlarını ve hangi kulüpte yer aldıklarını listeleyin. (`JOIN`)
      -  "Tiyatro Kulübü" üyelerini ve rollerini listeleyin. (`WHERE` ve `JOIN`)
      -  Tüm kulüplerde başkan olarak görev yapan öğrencileri listeleyin. (`WHERE`)
      -  Her kulübün kaç üyesi olduğunu listeleyin. (`GROUP BY` ve `COUNT`)
      -  Kuruluş yılı en eski olan kulübün üyelerini listeleyin. (`ORDER BY` ve `JOIN`)
      -  Öğrencilerin hangi tarihte hangi kulübe katıldıklarını listeleyin. (`SELECT` ve `JOIN`)
      -  "Müzik Kulübü"nde bulunan tüm rollerin bir listesini çıkarın. (`WHERE` ve `DISTINCT`)
      -  Her kulüpte kaç başkan olduğunu gruplandırarak listeleyin. (`GROUP BY` ve `COUNT`)
      -  Hangi öğrenci en son hangi kulübe katılmış, bu bilgiyi listeleyin. (`JOIN` ve `ORDER BY`)
      -  Birden fazla kulüpte yer alan öğrencileri ve katıldıkları kulüpleri listeleyin.  (`GROUP BY` ve `HAVING`)

**NOT**

Araştırmanız gereken konular olacaktır. Hem elinizdeki dökümanlardan, hem internetten yapacağınız araştırmalarla ödev çalışmalarınızı destekleyiniz. 