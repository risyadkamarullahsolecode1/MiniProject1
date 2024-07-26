using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public interface IOrderingSystem
    {
        void AddRestaurant(Restaurant restaurant);
        int PlaceOrder(string restaurantName, List<MenuItem> orderedItems);
        void DisplayOrderDetails(int OrderNumber);
        void CancelOrder(int OrderNumber);
        string GetOrderStatus(int OrderNumber);
    }
}
