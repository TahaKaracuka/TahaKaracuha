using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_SiniflarMetotlar.Shopping
{
    internal class Product
    {
        public Product()
        {
            
        }
        public Product(int id)
        {
            Id = id;
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } = 1;
    }
}
