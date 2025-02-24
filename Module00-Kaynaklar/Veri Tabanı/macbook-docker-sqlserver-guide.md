# MacBook için Docker, SQL Server 2019 ve Azure Data Studio Kurulum Rehberi

Arkadaşlar bu rehber, MacBook üzerinde Docker kurulumu, Docker üzerinde SQL Server 2019 container'ı oluşturma ve Azure Data Studio ile bu container'a bağlanma süreçlerini adım adım anlatmaktadır. Hem Intel işlemcili hem de Apple Silicon (M1/M2) işlemcili MacBook'lar için talimatlar içermektedir.

## 1. Docker Desktop Kurulumu

### Adım 1: Sistem Gereksinimlerini Kontrol Etme

- macOS 11 (Big Sur) veya daha yeni sürüm
- En az 4 GB RAM
- Intel işlemci veya Apple Silicon (M1/M2) işlemci

Not: İşlemci tipinizi öğrenmek için, Apple menüsünden "Bu Mac Hakkında" seçeneğine tıklayın.

### Adım 2: Docker Desktop'u İndirme

1. Resmi Docker web sitesine gidin: https://www.docker.com/products/docker-desktop
2. "Download for Mac" butonuna tıklayın.
3. İşlemci tipinize uygun sürümü seçin:
   - Intel işlemci için: "Mac with Intel chip"
   - Apple Silicon için: "Mac with Apple chip"

### Adım 3: Docker Desktop'u Yükleme

1. İndirilen .dmg dosyasını çift tıklayarak açın.
2. Docker uygulamasını Applications klasörüne sürükleyin.
3. Applications klasöründen Docker'ı başlatın.
4. Gerekli izinleri verin ve kurulum tamamlanana kadar bekleyin.

### Adım 4: Docker Desktop'u Başlatma ve Doğrulama

1. Docker Desktop başladıktan sonra, menü çubuğunda Docker ikonunun görünür olduğundan emin olun.
2. Terminal uygulamasını açın ve aşağıdaki komutu çalıştırarak Docker'ın düzgün çalıştığını doğrulayın:

   ```
   docker --version
   ```

   Bu komut, yüklü Docker sürümünü göstermelidir.

## 2. Docker Üzerinde SQL Server 2019 Container'ı Oluşturma

### Adım 1: SQL Server 2019 İmajını İndirme

1. Terminal uygulamasını açın.
2. Aşağıdaki komutu çalıştırarak SQL Server 2019 imajını indirin:

   ```
   docker pull mcr.microsoft.com/mssql/server:2019-latest
   ```

   Not: Bu komut, Microsoft Container Registry'den en son SQL Server 2019 imajını indirir.

Önemli Uyarı: Apple Silicon (M1/M2) işlemcili MacBook kullanıyorsanız, SQL Server'ın resmi Docker imajı doğrudan çalışmayacaktır. Bu durumda, Azure SQL Edge'i kullanmanız önerilir. Azure SQL Edge, SQL Server ile uyumlu bir sürümdür ve ARM64 mimarisini destekler. Azure SQL Edge için aşağıdaki komutu kullanın:

   ```
   docker pull mcr.microsoft.com/azure-sql-edge
   ```

### Adım 2: SQL Server 2019 Container'ını Oluşturma ve Çalıştırma

Intel işlemcili MacBook için:

1. Aşağıdaki komutu çalıştırarak SQL Server 2019 container'ını oluşturun ve başlatın:

   ```
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" -p 1440:1433 --name sql_server_2019_container -d mcr.microsoft.com/mssql/server:2019-latest
   ```

Apple Silicon (M1/M2) işlemcili MacBook için:

1. Aşağıdaki komutu çalıştırarak Azure SQL Edge container'ını oluşturun ve başlatın:

   ```
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" -p 1440:1433 --name azure_sql_edge_container -d mcr.microsoft.com/azure-sql-edge
   ```

Bu komutların açıklaması:
- `-e "ACCEPT_EULA=Y"`: Lisans anlaşmasını kabul eder.
- `-e "SA_PASSWORD=YourStrong@Passw0rd"`: SA kullanıcısı için güçlü bir şifre belirler.
- `-p 1440:1433`: Host makinenin 1433 portunu container'ın 1440 portuna yönlendirir.
- `--name`: Container'a bir isim atar.
- `-d`: Container'ı arka planda (detached mode) çalıştırır.

2. Container'ın çalışıp çalışmadığını kontrol etmek için aşağıdaki komutu kullanın:

   ```
   docker ps
   ```

   Bu komut, çalışan container'ların listesini gösterecektir.

### Adım 3: SQL Server Container'ının Durumunu Kontrol Etme

1. Container'ın loglarını görüntülemek için aşağıdaki komutu kullanın:

   Intel işlemcili MacBook için:
   ```
   docker logs sql_server_2019_container
   ```

   Apple Silicon işlemcili MacBook için:
   ```
   docker logs azure_sql_edge_container
   ```

   Loglar arasında "SQL Server is now ready for client connections" mesajını görürseniz, SQL Server başarıyla başlatılmış demektir.

## 3. Azure Data Studio ile SQL Server Container'ına Bağlanma

### Adım 1: Azure Data Studio'yu İndirme ve Kurma

1. Microsoft'un resmi web sitesinden Azure Data Studio'yu indirin: https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio
2. MacOS için .zip dosyasını indirin.
3. İndirilen .zip dosyasını açın ve Azure Data Studio uygulamasını Applications klasörüne sürükleyin.

### Adım 2: Azure Data Studio'yu Başlatma ve SQL Server'a Bağlanma

1. Applications klasöründen Azure Data Studio'yu başlatın.
2. Sol üst köşedeki "New Connection" (Yeni Bağlantı) butonuna tıklayın.
3. Bağlantı detaylarını girin:
   - Server: `localhost,1433`
   - Authentication Type: SQL Login
   - User name: `sa`
   - Password: `YourStrong@Passw0rd` (Docker container'ını oluştururken belirlediğiniz şifre)
   - Database: Boş bırakın veya `master` yazın
4. "Connect" (Bağlan) butonuna tıklayın.

### Adım 3: Bağlantıyı Doğrulama

1. Bağlantı başarılı olduysa, sol tarafta sunucu ve veritabanları görünecektir.
2. Yeni bir sorgu penceresi açmak için "New Query" (Yeni Sorgu) butonuna tıklayın.
3. Aşağıdaki SQL sorgusunu yazın ve çalıştırın:

   ```sql
   SELECT @@VERSION;
   ```

   Bu sorgu, SQL Server sürümünü gösterecektir.

Tebrikler! Artık MacBook'unuzda Docker üzerinde çalışan bir SQL Server instance'ına Azure Data Studio ile başarıyla bağlandınız.

Not: Apple Silicon (M1/M2) işlemcili MacBook'larda Azure SQL Edge kullanıyorsanız, bazı SQL Server özelliklerinin sınırlı olabileceğini veya farklılık gösterebileceğini unutmayın. Çoğu temel SQL işlevi aynı şekilde çalışacaktır, ancak ileri düzey özelliklerde farklılıklar olabilir.

