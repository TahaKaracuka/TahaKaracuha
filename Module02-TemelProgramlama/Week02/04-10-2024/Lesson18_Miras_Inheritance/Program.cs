using Lesson18_Miras_Inheritance.Eshop;
using Lesson18_Miras_Inheritance.Siniflar;

namespace Lesson18_Miras_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstSample
            //Otomobil otomobil1 = new Otomobil();
            //otomobil1.Tur = "Otomobil";
            //otomobil1.Marka = "BMW";
            //otomobil1.Model = "316i";
            //otomobil1.DisplayInfo();
            //otomobil1.KornaCal();


            //Vapur vapur1 = new Vapur();
            //vapur1.Tur = "Vapur";
            //vapur1.GemiAd = "Barbaros Hayrettin Paşa";
            //vapur1.GemiNo = 11780;
            //vapur1.DisplayInfo();
            //vapur1.KornaCal();
            #endregion

            List<Brand> brands = new List<Brand>
            {
                new Brand
                {
                     Id=1,
                     Name="Apple",
                     Country="USA",
                     Description="Kendine has bir marka",
                     IsActive=true,
                     CreatedDate=DateTime.Now
                },
                new Brand
                {
                     Id=2,
                     Name="Lenovo",
                     Country="USA",
                     Description="PC'nin mucidi!",
                     IsActive=true,
                     CreatedDate=DateTime.Now
                },
                new Brand
                {
                     Id=3,
                     Name="Monster",
                     Country="Turkey",
                     Description="Oyun canavarı!",
                     IsActive=false,
                     CreatedDate=DateTime.Now
                }
            };

            Product product1 = new Product
            {
                Id = 1,
                Name = "Macbook Air M2 16gb",
                Properties = "M2 işlemci, 16 gb ram, 512 gb SSD",
                Price = 62500,
                TaxRate = 0.2m,
                BrandId = 1
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "IPhone 13",
                Properties = "128 gb",
                Price = 48500,
                TaxRate = 0.2m,
                BrandId = 1
            };

            Product product3 = new Product
            {
                Id = 3,
                Name = "Lenovo XYZ1",
                Properties = "Intel Ultra İşlemci i9",
                Price = 82500,
                TaxRate = 0.2m,
                BrandId = 2
            };

            Product product4 = new Product
            {
                Id = 4,
                Name = "Monster Captiva",
                Properties = "AMD 9 64 gb ram",
                Price = 72500,
                TaxRate = 0.2m,
                BrandId = 3
            };

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            foreach (Product product in products)
            {
                string brandName="";
                foreach (Brand brand in brands)//BrandId'ye göre BrandName'i buluyoruz
                {
                    if (product.BrandId == brand.Id)
                    {
                        brandName= brand.Name;
                        break;
                    }
                }
                Console.WriteLine($"Id: {product.Id} - Ürün: {product.Name} - {brandName}");
            }

            //foreach (Brand brand in brands)
            //{
            //    string isActive = brand.IsActive ? "Aktif Marka" : "Pasif Marka";
            //    Console.WriteLine($"{brand.Id}-{brand.Name}-{isActive}");
            //}
        }
    }
}
