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
        public bool IsCanceled { get; set; }


        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            OrderedItems = new List<MenuItem>();
            IsCanceled = false;
        }

        public void AddMenuItem(MenuItem item)
        {
            OrderedItems.Add(item);
        }

        public int CalculateTotal()
        {
            return OrderedItems.Sum(item => item.CalculatedPrice());
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

    }
}
