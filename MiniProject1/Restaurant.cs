using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class Restaurant
    {
        public string Name { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Order> Orders { get; set; }

        public Restaurant(string name) 
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<Order>();
        }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }

        public void ReceiveOrder(Order order)
        {
            Orders.Add(order);
        }

        public int CalculateRevenue()
        {
            int totalRevenue = 0;
            foreach (var order in Orders)
            {
                totalRevenue += order.CalculateTotal();
            }
            return totalRevenue;
        }
    }
}
