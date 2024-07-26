using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public abstract class MenuItem
    {
        //Properti
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        //Constructor
        protected MenuItem(string name, int price, string description) 
        { 
            Name = name;
            Price = price;
            Description = description;
        }

        //Abstrak
        public abstract int CalculatedPrice();
    }
}
