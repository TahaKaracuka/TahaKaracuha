using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_Miras_Inheritance.Siniflar
{
    internal class Otomobil:Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tür: {Tur}");
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
        }
    }
}
