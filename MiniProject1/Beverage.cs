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

        public Beverage(string name, int price, string description) : base(name, price, description)
        {
        }

        public override int CalculatedPrice()
        {
            int adjustedPrice = Price;

            switch (Size.ToLower())
            {
                case "small":
                    adjustedPrice = 0; 
                    break;
                case "medium":
                    adjustedPrice = 3000; 
                    break;
                case "large":
                    adjustedPrice = 4000; 
                    break;
                default:
                    throw new ArgumentException("Size harusnya string berupa 'Small', 'Medium', atau 'Large'.");
            }

            return adjustedPrice;
        }
    }
}
