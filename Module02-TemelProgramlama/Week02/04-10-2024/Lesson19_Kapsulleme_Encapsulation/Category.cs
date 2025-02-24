﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Kapsulleme_Encapsulation
{
    internal class Category
    {
        public Category(string disaridanGelenKategoriAdi)
        {
            Name = disaridanGelenKategoriAdi;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NameLength { get { return Name.Length; } }

    }
}
