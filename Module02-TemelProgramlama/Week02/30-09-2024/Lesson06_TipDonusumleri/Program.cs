namespace Lesson06_TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit converting
            byte a = 56;//int to byte implicit converting(casting)
            //byte b = 256;//int to byte dönüştürmesini yapamıyor

            //int c = 50000000;
            //long d = c;

            ////explicit converting
            //double e = 512;
            //Console.WriteLine(e);
            //int f = Convert.ToInt32(e);
            //Console.WriteLine(f);
            //byte g = Convert.ToByte(e); //Bu kod runtime error verir
            //byte g = (byte)e;
            //Console.WriteLine(g);
            //   1 1 1 1 1 1 1 1    = 255
            // 1 0 0 0 0 0 0 0 0    = 256
            // 1 0 0 0 0 0 0 0 1    = 257
            // 1 0 0 0 0 0 0 1 0    = 258
            string age = "56";
            int diff = 65 - byte.Parse(age);
            int diff2 = 65 - Convert.ToByte(diff);

            string size = "173";
            int sizeInt = int.Parse(size);
            Console.WriteLine(3+3+size);
            Console.WriteLine(3+3+sizeInt);

        }
    }
}
