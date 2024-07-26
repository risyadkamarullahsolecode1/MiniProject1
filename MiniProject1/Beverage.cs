using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Beverage : MenuItem
    {
        public string Size { get; set; }

        public Beverage(string name, int price, string decription, string size) : base(name, price, decription)
        {
            Size = size;
        }

        public override int CalculatedPrice()
        {
            return Price;
        }
    }
}
