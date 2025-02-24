using Lesson14_SiniflarMetotlar.Members;
using Lesson14_SiniflarMetotlar.Shopping;

namespace Lesson14_SiniflarMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(4,"Macbook Pro M2");
            Console.WriteLine(product1.Name);
            Role role1 = new Role
            {
                Id = 1,
                Name = "Admin",
                Description = "Yönetici rolü"
            };
            role1.DisplayInfo();
        }
    }
}