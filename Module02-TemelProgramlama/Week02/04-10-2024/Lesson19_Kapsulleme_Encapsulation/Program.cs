namespace Lesson19_Kapsulleme_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();
            //if (product.SetName("Alo")==false)
            //{
            //    Console.WriteLine("Lütfen 5 karakter ve daha uzun bir isim giriniz.");
            //}
            //else
            //{
            //    string productName = product.GetName();
            //    Console.WriteLine(productName);
            //}

            Category category = new Category("Bilgisayar");
            category.Id = 56;
            Console.WriteLine(category.Id);
            Console.WriteLine(category.NameLength);
            Console.WriteLine(category.Name);


            //Adı category1 olan yeni bir Category nesnesi tanımlayın.
            //category1 nesnesinin Name: Telefon olsun. 
            //Id:5, Description:"Telefon kategorisi" olsun ve bu bilgiler nesne oluşturulurken verilsin.
            Category category1 = new Category("Telefon")
            {
                Id = 5,
                Description = "Telefon kategorisi"
            };
        }
    }
}
