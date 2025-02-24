namespace Lesson09_Metotlar
{
    internal class Program
    {
        //static sözcüğünün ne işe yaradığını OOP konularında öğreneceğiz.
        static void Merhaba()
        {
            Console.WriteLine("Merhaba dünya!");
            Console.WriteLine("Sana da merhaba!");
            Console.WriteLine("****************");
        }

        // C#'ta önemli geleneklerden biri metot isimlerinin Pascal Case ile yazılmasıdır. PascalCase her kelimenin ilk harfi büyük, geri kalanları küçük şeklinde yazılır.
        static int Topla()
        {
            int a = 4 + 1;
            return a;
        }
        
        static int IkiSayiyiTopla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        static int UcSayiyiTopla(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }

        static decimal CalculateIncludeTax(decimal productPrice, decimal rateOfTax)
        {
            return productPrice * (1 + rateOfTax);
        }
        static decimal CalculateTax(decimal productPrice)
        {
            double rateOfTax = 0.2;
            decimal tax = productPrice * (decimal)rateOfTax;
            return tax;
        }

        static string GenerateSmsCode()
        {
            Random rnd = new Random();
            string n1 = rnd.Next(0, 10).ToString();
            string n2 = rnd.Next(0, 10).ToString();
            string n3 = rnd.Next(0, 10).ToString();
            string n4 = rnd.Next(0, 10).ToString();
            string n5 = rnd.Next(0, 10).ToString();
            string n6 = rnd.Next(0, 10).ToString();
            return $"{n1}{n2}{n3}-{n4}{n5}{n6}";
        }

        //Bir dotnet console uygulaması ilk çalıştırıldığında Main metodunu çalıştırır.
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateSmsCode());
            //decimal price = 100;
            //decimal result = price + CalculateTax(price);
            //Console.WriteLine(result.ToString("N0"));

            //decimal result2 = CalculateIncludeTax(1250, 0.18m);
            //Console.WriteLine(result2.ToString("N0"));


            //Console.WriteLine(IkiSayiyiTopla(5, 18));
            //Console.WriteLine(IkiSayiyiTopla(15, 28));
            //Console.WriteLine(UcSayiyiTopla(180, 5,10));




            //Merhaba();
            //int a = 45;
            //double b = 56;
            //string message = "Nasılsın";
            //Merhaba();
            //Merhaba();
            //Merhaba();
            //int number = Topla();
            //Console.WriteLine(number*number);

        }
    }
}
