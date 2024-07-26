using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Dessert:MenuItem
    {
        public string SugarLevel {  get; set; }

        public Dessert(string name, int price, string decription, string sugarLevel) : base(name, price, decription)
        {
            SugarLevel = sugarLevel;
        }

        public override int CalculatedPrice()
        {
            return Price;
            /**int adjustedPrice = Price;

            switch (SugarLevel.ToLower())
            {
                case "low":
                    adjustedPrice = 0; 
                    break;
                case "medium":
                    adjustedPrice = 5000; 
                    break;
                case "high":
                    adjustedPrice = 6000; 
                    break;
                default:
                    throw new ArgumentException("Sugar harusnya diisi string berupa 'Low', 'Medium', atau 'High'.");
            }

            return adjustedPrice;**/
        }
    }
}
