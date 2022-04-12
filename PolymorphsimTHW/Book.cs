using System;
using System.Collections.Generic;
using System.Text;

namespace PolyHW
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public override string GetInfo()
        {
            return Name + " " + Author + " " + Genre + " " + Price;
        }
    }
}
