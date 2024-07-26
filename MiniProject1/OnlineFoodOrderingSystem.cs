using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public class OnlineFoodOrderingSystem : IOrderingSystem
    {
        private List<Restaurant> restaurants;
        private Dictionary<int, Order> orders;
        //untuk menghitung nomor antrian orderan
        private int nextOrderNumber;

        public OnlineFoodOrderingSystem()
        {
            restaurants = new List<Restaurant>();
            orders = new Dictionary<int, Order>();
            nextOrderNumber = 1;
        }

        //Method AddRestaurant
        public void AddRestaurant(Restaurant restaurant)
         {
             restaurants.Add(restaurant);
         }


        // Method PlaceOrder
        public int PlaceOrder(string restaurantName, List<MenuItem> orderedItems)
        {
            var restaurant = restaurants.Find(r => r.Name == restaurantName);
            if (restaurant == null) throw new Exception("Restaurant tidak ada.");

            var order = new Order(nextOrderNumber);
            foreach (var item in orderedItems)
            {
                order.AddMenuItem(item);
            }
            restaurant.ReceiveOrder(order);
            orders[nextOrderNumber] = order;
            nextOrderNumber++;
            return order.OrderNumber;
        }
        // Display Order
        public void DisplayOrderDetails(int orderNumber)
        {
            if (!orders.ContainsKey(orderNumber))
            {
                throw new Exception("Order tidak ditemukan");
            }

            var order = orders[orderNumber];
            Console.WriteLine($"Order Number: {order.OrderNumber}");
            Console.WriteLine("Ordered Items:");
            foreach (var item in order.OrderedItems)
            {
                Console.WriteLine($"- {item.Name}: {item.Price} ({item.Description})");
            }
            Console.WriteLine($"Total: {order.CalculateTotal()}");
        }

        public void CancelOrder(int orderNumber)
        {
            if (!orders.ContainsKey(orderNumber))
            {
                throw new Exception("Order tidak ditemukan");
            }

            var order = orders[orderNumber];
            order.Cancel();
            Console.WriteLine($"Order Number {orderNumber} telah di cancel.");
        }

        public string GetOrderStatus(int orderNumber)
        {
            if (!orders.ContainsKey(orderNumber))
            {
                return $"Order Number {orderNumber} tidak ditemukan";
            }

            var order = orders[orderNumber];
            if (order.IsCanceled)
            {
                return $"Order Number {orderNumber} telah di cancel.";
            }
            else
            {
                return $"Order Number {orderNumber} di proses.";
            }

        }

    }
}
