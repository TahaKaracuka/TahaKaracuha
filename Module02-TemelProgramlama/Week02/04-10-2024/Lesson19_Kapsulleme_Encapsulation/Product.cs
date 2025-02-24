using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Kapsulleme_Encapsulation
{
    internal class Product
    {
        int id;
        decimal price;
        string name;
        bool isActive;

        public bool SetName(string _name)
        {
            if (_name.Length >= 5)
            {
                name = _name;
                return true;
            }
            name = string.Empty;
            return false;
        }
        public string GetName()
        {
            return name.ToUpper();
        }
    }
}
