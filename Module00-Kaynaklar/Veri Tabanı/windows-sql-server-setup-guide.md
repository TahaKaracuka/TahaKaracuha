# Windows için Microsoft SQL Server Kurulum ve Kullanım Kılavuzu

1. SQL Server İndirme ve Kurulum:
   - Microsoft'un resmi web sitesine gidin (https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
   - "SQL Server 2022 Express" sürümünü seçin ve indirin.
   - İndirilen .exe dosyasını çalıştırın.
   - "Basic" kurulum tipini seçin (başlangıç için en uygunu budur).
   - Lisans sözleşmesini kabul edin.
   - Kurulum konumunu seçin (varsayılan konum genellikle uygundur).
   - "Install" butonuna tıklayın ve kurulumun tamamlanmasını bekleyin.

2. SQL Server Management Studio (SSMS) İndirme ve Kurulum:
   - https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms adresine gidin.
   - En son SSMS sürümünü indirin.
   - İndirilen .exe dosyasını çalıştırın.
   - Kurulum sihirbazını takip edin ve varsayılan ayarları kabul edin.
   - Kurulum tamamlandığında bilgisayarınızı yeniden başlatın.

3. Azure Data Studio Kurulumu (macOS için SSMS alternatifi):
   - https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio adresine gidin.
   - macOS için Azure Data Studio'yu indirin.
   - İndirilen .zip dosyasını açın ve uygulamayı "Applications" klasörüne taşıyın.

## Veritabanı Sunucusuna Bağlanma

### SSMS kullanarak:

1. SQL Server Management Studio'yu açın.
2. Server name: "localhost" veya ".\SQLEXPRESS" yazın.
3. Authentication: "Windows Authentication" seçin.
4. "Connect" butonuna tıklayın.

### zure Data Studio kullanarak:

1. Azure Data Studio'yu açın.
2. "New Connection" butonuna tıklayın.
3. Server: "localhost,1433" yazın.
4. Authentication type: "SQL Login" seçin.
5. User name: "sa" girin.
6. Password: Belirlediğiniz şifreyi girin
7. "Connect" butonuna tıklayın.
