﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_Miras_Inheritance.Siniflar
{
    internal class Vapur:Arac   
    {
        public string GemiAd { get; set; }
        public int GemiNo { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tür: {Tur}");
            Console.WriteLine($"Ad: {GemiAd}");
            Console.WriteLine($"No: {GemiNo}");
        }

        public override void KornaCal()
        {
            Console.WriteLine("Sirenler öttü!");
        }
    }
}
