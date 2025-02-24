namespace Lesson04_VeriYapilariveDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler
            int age = 23;
            string name;
            name = "Ali";
            string ageOfAli = "23";
            //camelCase
            // studentNumber
            // firstName
            // first-name


            // Veri Tipleri
            // 1) Sayısal Tipler
            sbyte studentNot1 = 2;
            byte studentNot = 34;

            short orderCount = 5000;
            ushort orderCount2 = 5;

            int totalLastYear = 10000000;
            uint totalLastYear2 = 3;

            long count = 58566;
            ulong count2 = 3;

            //Console.Write("Short tipinin maksimum değeri: ");
            //Console.WriteLine(short.MaxValue);
            //Console.Write("Short tipinin minimum değeri: ");
            //Console.WriteLine(short.MinValue);
            //Console.Write("Short tipinin bellekteki boyutu :");
            //Console.WriteLine(sizeof(long) * 8);


            //Console.WriteLine("Short Max Value: " + short.MaxValue);
            //Console.WriteLine("Short Min Value: " + short.MinValue);
            //Console.WriteLine("Short Size: " + sizeof(short) + " byte");

            string firstName = "Deniz";
            string lastName = "Ündav";
            string gender = "Bay";

            Console.WriteLine("Sayın " + gender + " " + firstName + " " + lastName);

            Console.WriteLine($"Sayın {gender} {firstName} {lastName}");




        }
    }
}
