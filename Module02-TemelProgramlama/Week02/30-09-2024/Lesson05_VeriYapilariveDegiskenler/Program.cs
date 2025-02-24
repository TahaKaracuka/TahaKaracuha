namespace Lesson05_VeriYapilariveDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ondalıklı Sayılar
            //float number1 = 45.25f;
            //double number2 = 56.98;
            //decimal number3 = 56.89m;

            //Console.WriteLine($"number1 sayısının bellekte kapladığı alan: {sizeof(float)}");
            //Console.WriteLine($"number2 sayısının bellekte kapladığı alan: {sizeof(double)}");
            //Console.WriteLine($"number3 sayısının bellekte kapladığı alan: {sizeof(decimal)}");

            // Metinsel veri tipleri
            //char karakter1 = 'f';
            //char karakter2 = '%';

            //string adSoyad = "Alex de Souza";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine(adSoyad[1]);

            //char karakter3 = adSoyad[6];

            // camelCase: ilk sözcüğün tamamı küçük, geri kalan sözcüklerin ilk harfi büyük, gerisi küçük
            // adSoyad, firstName, uyeOlusTarihi

            // Mantıksal veri
            bool isActive = true;
            bool isDeleted = false;

            const int a = 45;
            const int b = 50;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine("*************************");

            //a = a + 8;
            //b = b + 9;
            int c;
            c = a + b;
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"a+b: {c}");


        }
    }
}
