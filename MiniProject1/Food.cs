using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Food:MenuItem
    {
        public int Spiciness {  get; set; }

        public Food(string name, int price, string decription, int spiciness) : base(name, price, decription)
        {
            Spiciness = spiciness;
        }

        public override int CalculatedPrice()
        { 
            return Price;
        }
    }
}
