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
            int adjustedPrice = Price;

            switch (Spiciness)
            {
                case 1:
                    adjustedPrice += 0; 
                    break;
                case 2:
                    adjustedPrice = 4000; 
                    break;
                case 3:
                    adjustedPrice = 5000; 
                    break;
                default:
                    throw new ArgumentException("Spiciness harus berada di angka 1 sampai 3.");
            }

            return adjustedPrice;
        }
    }
}
