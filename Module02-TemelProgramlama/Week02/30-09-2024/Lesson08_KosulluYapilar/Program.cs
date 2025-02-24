namespace Lesson08_KosulluYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programlarımızda duruma göre farklı akışlardan devam edilmesini sağlayan yapılardır.
            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    //üstteki koşul doğruysa buraya yazdığımız kodlar çalışır.
            //    Console.WriteLine($"Girdiğiniz {number} sayısı pozitiftir.");
            //}
            //else if (number == 0)
            //{
            //    //ilk ifteki koşul doğru değilse, else ifteki koşula bakar ve bu koşul doğruysa buraya yazdığımız kodlar çalışır
            //    Console.WriteLine($"Girdiğiniz sayı sıfırdır.");
            //}
            //else
            //{
            //    //if satırında yazdığımız koşul doğru değil ise buraya yazdığımız kodlar çalışır
            //    Console.WriteLine($"Girdiğiniz {number} sayısı negatiftir.");
            //}

            //string currentUserName = "daniel";
            //string currentPassword = "Qwe123.";

            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string userName = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //string password = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //if (userName == currentUserName && password == currentPassword)
            //{
            //    Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");
            //    Console.WriteLine($"Hoşgeldiniz {userName}");
            //}
            //else if(userName!=currentUserName && password==currentPassword)
            //{
            //    Console.WriteLine("Giriş işlemi başarısız oldu.");
            //    Console.WriteLine($"Kullanıcı adınızı kontrol edip yeniden deneyiniz!");
            //}
            //else if(userName==currentUserName && password!=currentPassword)
            //{
            //    Console.WriteLine("Giriş işlemi başarısız oldu.");
            //    Console.WriteLine($"Sevgili {userName}, şifreniz hatalıdır, yeniden deneyiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş işlemi başarısız oldu!");
            //    Console.WriteLine("Lütfen bilgilerinizi kontrol edip, yeniden deneyiniz.");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //DateTime date = new DateTime(2024, 6, 24);
            //int month = date.Month;
            //string message;
            //if (month == 12 || month == 1 || month == 2)
            //{
            //    message = "Kış";
            //}
            //else if(month>=3 && month<=5) 
            //{
            //    message = "İlkbahar";
            //}
            //else if(month>=6 && month<=8)
            //{
            //    message = "Yaz";
            //}
            //else
            //{
            //    message = "Sonbahar";
            //}
            //Console.WriteLine($"{date} tarihi {message} mevsimine aittir!");


            //DateTime date = new DateTime(2024, 6, 24);
            //int month = date.Month;
            //string message;
            //switch(month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        message = "Kış";
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        message = "İlkbahar";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        message = "Yaz";
            //        break;
            //    default:
            //        message = "Sonbahar";
            //        break;
            //}


            //Ternary If
            //Console.Write("Yaşınızı giriniz: ");
            //byte age = byte.Parse(Console.ReadLine());
            //string message = age >= 18 ? "Giriş yapabilirsiniz" : "Giriş yapamazsınız";
            //if (age >= 18)
            //{
            //    message = "Giriş yapabilirsiniz!";
            //}
            //else
            //{
            //    message = "Giriş yapamazsınız";
            //}

            //Console.WriteLine(message);


            //Console.Write("Yaşınızı giriniz: ");
            //byte age = byte.Parse(Console.ReadLine());
            //Console.WriteLine(age>=18?"Giriş yapabilirsiniz":"Giriş yapamazsınız");

            // Not Sistemi:
            /*
                0-45:   E
                46-60:  D
                61-70:  C
                71-85:  B
                86-100: A
             */
            Console.Write("100lük sistemdeki puanı giriniz: ");
            byte point = byte.Parse(Console.ReadLine());

            char result = point <= 45 ? 'E' :
                            point <= 60 ? 'D' :
                                point <= 70 ? 'C' :
                                    point <= 85 ? 'B' : 'A';
            Console.WriteLine($"100lük sistemdeki puanınız: {point}");
            Console.WriteLine($"Harf sistemindeki notunuz: {result}");  

            //Egzersiz: Bu örneği if ile ve switch ile de yapın.

                                        
        }
    }
}
