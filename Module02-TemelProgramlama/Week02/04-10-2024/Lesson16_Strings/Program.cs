
namespace Lesson16_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yazi;
            yazi = "Bu bir string ifadedir";
            //StringIntro(yazi);
            StringMethods();
        }
        static void StringIntro(string yazi)
        {
            String value = "Türkiye'nin başkenti Ankara'dır";
            System.String newValue = "Yeni değer";
            //Console.WriteLine(value.GetType());
            //Console.WriteLine(yazi.GetType());

            //for (int i = 0; i < value.Length; i++)
            //{
            //    if (i+1<value.Length && value[i + 1] == '\'')
            //    {
            //        Console.WriteLine($"{value[i]}{value[i + 1]}");
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(value[i]);
            //    }
            //}

            //foreach çözümü
            //int index = 1;
            //foreach (var letter in value)
            //{
            //    if (index<value.Length && value[index] == '\'')
            //    {
            //        Console.WriteLine($"{letter}{value[index]}");
            //    }
            //    else if (letter != '\'')
            //    {
            //        Console.WriteLine(letter);
            //    }
            //    index++;
            //}

        }
        static void StringMethods() 
        {
            string text = "InfoTech Academy MSCD Yazılım Eğitimine hoş geldiniz!";
            //Console.WriteLine(text);
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());

            //object newText = text.Clone();

            //Console.WriteLine($"text i harfi ile bitiyor mu? {text.ToLower().EndsWith("i")}");
            //Console.WriteLine($"text Info ifadesi ile başlıyor mu? {text.StartsWith("Info")}");

            //Console.WriteLine($"T harfi text içerisinde kaçıncı sırada?: {text.IndexOf("T")}");
            //Console.WriteLine($"MSCD ifadesi text içerisinde kaçıncı sırada?: {text.IndexOf("MSCD")}");
            //Console.WriteLine($"text içerisindeki en son e harfinin index numarası: {text.LastIndexOf("e")}");
            //Console.WriteLine(text.IndexOf("x"));

            //Console.WriteLine(text.Insert(9,"(Mecidiyeköy) "));

            //Console.WriteLine(text.Substring(0,8));
            //Console.WriteLine(text.Substring(17,4));
            //Console.WriteLine(text.Substring(17));

            string address = "Kemal Candan mh., Karanfil sk., Nida apt, D:5, Üsküdar, İstanbul";
            string[] addressArray = address.Split(",");
            foreach (string str in addressArray)
            {
                Console.WriteLine(str.Trim());
            }
        }
    }
}
