# T-SQL Sık Kullanılan Veri Tipleri ve Özellikleri

| Veri Tipi       | Boyut/Aralık                 | Açıklama                                                                                          |
|-----------------|------------------------------|---------------------------------------------------------------------------------------------------|
| **int**         | -2,147,483,648 ile 2,147,483,647 | Tam sayı değerleri için kullanılır.                                                               |
| **smallint**    | -32,768 ile 32,767             | Daha küçük tam sayı değerleri için kullanılır.                                                    |
| **tinyint**     | 0 ile 255                     | Pozitif tam sayı değerleri için kullanılır.                                                       |
| **bigint**      | -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 | Çok büyük tam sayı değerleri için.                                                                |
| **decimal(p,s)**| p: Maksimum 38 hane, s: Kesir kısmı | Ondalık sayılar için kullanılır. p (precision) toplam basamak sayısını, s (scale) ise kesirli kısmı belirtir. |
| **float**       | Yaklaşık ±1.79E+308           | Kayan noktalı (ondalık) sayılar için.                                                             |
| **char(n)**     | Maksimum 8,000 karakter       | Sabit uzunlukta metinler için kullanılır. **Türkçe karakterler desteklenir.**                       |
| **varchar(n)**  | Maksimum 8,000 karakter       | Değişken uzunlukta metinler için kullanılır. **Türkçe karakterler desteklenir.**                   |
| **nchar(n)**    | Maksimum 4,000 karakter       | Unicode karakter seti kullanır, sabit uzunlukta. **Türkçe karakterler için uygundur.**            |
| **nvarchar(n)** | Maksimum 4,000 karakter       | Unicode karakter seti kullanır, değişken uzunlukta. **Türkçe karakterler için uygundur.**         |
| **text**        | 2 GB'a kadar                  | Uzun metin verileri için kullanılır. Ancak modern sistemlerde `varchar(max)` yerine tercih edilmelidir. |
| **nvarchar(max)**| 2 GB'a kadar                  | Çok büyük Unicode metinler için kullanılır. **Türkçe karakterler için uygundur.**                  |
| **bit**         | 1 veya 0                      | Boolean değerleri (True/False) temsil eder.                                                       |
| **datetime**    | 1 Ocak 1753 ile 31 Aralık 9999 | Tarih ve saat verileri için kullanılır.                                                           |
| **date**        | 1 Ocak 0001 ile 31 Aralık 9999 | Yalnızca tarih bilgisi tutar.                                                                     |
| **time**        | 00:00:00.0000000 ile 23:59:59.9999999 | Yalnızca saat bilgisi tutar.                                                                     |
| **datetime2**   | 1 Ocak 0001 ile 31 Aralık 9999 | Tarih ve saat verileri için kullanılır, daha hassas zaman dilimleri için kullanılır.               |
| **binary(n)**   | Maksimum 8,000 byte           | Sabit uzunlukta ikili veri (binary data) için kullanılır.                                         |
| **varbinary(n)**| Maksimum 8,000 byte           | Değişken uzunlukta ikili veri için kullanılır.                                                    |
| **uniqueidentifier**| 16 byte                  | Global benzersiz tanımlayıcı (UUID) için kullanılır.                                              |

### Türkçe Karakterler için Uygun Veri Tipleri:
- **nchar** ve **nvarchar** veri tipleri, Unicode desteği sağladığı için Türkçe karakterler (ç, ğ, ö, ş, ü, ı) ile uyumlu veri tutar. Metin verilerinde Türkçe karakterlerin düzgün kaydedilmesi için bu veri tiplerini tercih etmek önemlidir.
