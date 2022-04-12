using System;
using System.Collections.Generic;
using System.Text;

namespace PolyHW
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract string GetInfo();
    }
}
