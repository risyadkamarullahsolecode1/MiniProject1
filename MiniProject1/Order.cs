using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Order
    {
        //Properti
        public int OrderNumber { get; }
        public List<MenuItem> OrderedItems { get; }


        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            OrderedItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            OrderedItems.Add(item);
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (var item in OrderedItems)
            {
                total += item.CalculatedPrice();
            }
            return total;
        }
  
    }
}
