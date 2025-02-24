
namespace Lesson13_Siniflar
{
    class House
    {
        public string streetName;
        public int doorNumber;
    }
    
    class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string userName;
    }
    
    //class Product
    //{
    //    // Sınıfların içindeki değişkenlerin default erişim belirleyici private'dır. Biz burada belirgin olsun diye yazdık, yazmasaydık da olurdu.
    //    private int _id; // bunlara field diyoruz, bu classtan yaratılan nesnenin içindeki bilgileri tutan değişkenler.
    //    private string _name;
    //    private decimal _price;

    //    public void SetPrice(decimal price)
    //    {
    //        if(price < 0)
    //        {
    //            _price = 0;
    //        }
    //        else
    //        {
    //            _price = price;
    //        }
            
    //    }
    //    public decimal GetPrice()
    //    {
    //        return _price;
    //    }

    //}
    
    //class Product
    //{
    //    int id;
    //    public int Id {
    //        get
    //        {
    //            return id;
    //        }
    //        set
    //        {
    //            id = value;
    //        }
    //    }

    //    private decimal price;

    //    public decimal Price
    //    {
    //        get { return price; }
    //        set { price = value > 0 ? value : 0; }
    //    }

    //    public string Name { get; set; }

    //}
    
    class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int GetNameLenght { get { return Name.Length; } }//readonly/salt okunur
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP Giriş
            // Nesne Yönelimli Programlama-Object Oriented Programming(OOP)
            // Sınıflar nesnelerin kalıpları, şablonlarıdır. Ne gibi özelliklere sahip olduğunu belirler. Dolayısıyla nesneler, sınıflardan yaratılır. Bu bağlamda c# için her şey bir NESNE'dir.
            //int number;
            //number = 56;

            //House house1;
            //house1= new House();
            //house1.streetName = "Elf sokağı";
            //house1.doorNumber = 56;

            //Console.WriteLine(house1.streetName);
            //Console.WriteLine(house1.doorNumber);
            #endregion

            #region Örnek1
            //User user1 = new User();
            //user1.id = 1;
            //user1.firstName = "Ali";
            //user1.lastName = "Cabbar";
            //user1.email = "alicabbar@roman.com";
            //user1.userName = "alicabbar";
            //user1.password = "1234";

            //User user2 = new User()//bu aç kapa parantez bu durumda zorunlu değil
            //{
            //    id = 2,
            //    firstName = "Kemal",
            //    lastName = "Kum",
            //    email = "kemalkum@gmail.com",
            //    userName = "kemalkum",
            //    password = "qwe12"
            //};

            //User user3 = new()
            //{
            //    userName="canan",
            //    firstName=""
            //};
            //Console.WriteLine(user3.firstName);
            #endregion

            #region Örnek2
            //Product product1 = new Product();
            //product1.SetPrice(-150);
            //Console.WriteLine(product1.GetPrice());

            //Product product2 = new Product();
            //product2.SetPrice(400);
            //Console.WriteLine(product2.GetPrice());

            //Product product3 = new Product();
            //product3.SetPrice(-1400);
            //Console.WriteLine(product3.GetPrice());
            #endregion

            #region Örnek3
            //Product product1 = new Product();
            //product1.Price = 100;
            //product1.Name = "IPhone14";
            //Console.WriteLine(product1.GetNameLenght);
            #endregion
        }
    }
}
