// See https://aka.ms/new-console-template for more information

using MiniProject1;

OnlineFoodOrderingSystem orderingSystem = new OnlineFoodOrderingSystem();

// Create restaurants
Restaurant restaurant1 = new Restaurant("MC Donald");
Restaurant restaurant2 = new Restaurant("Mie Gacoan");
Restaurant restaurant3 = new Restaurant("Holland Bakery");

// Add restaurants to the system
orderingSystem.AddRestaurant(restaurant1);
orderingSystem.AddRestaurant(restaurant2);
orderingSystem.AddRestaurant(restaurant3);

// Add menu items to the restaurants
restaurant1.AddMenuItem(new Food("Burger", 40000, "Spicy Beef Burger", 2));
restaurant1.AddMenuItem(new Dessert("MC Flurry", 20000, "Chocolate Oreo MC Flurry", "High"));
restaurant2.AddMenuItem(new Beverage("Es Teh", 5000, "Es Teh Manis", "Large"));
restaurant2.AddMenuItem(new Food("Mie Gacoan", 15000, "Mie Gacoan Pangsit level 2", 1));
restaurant3.AddMenuItem(new Dessert("Bolu Gulung", 25000, "Bolu Gulung Moka", "Low"));

// Place order restaurant 1
var order1Items = new List<MenuItem> {
            restaurant1.Menu[0], 
            restaurant1.Menu[1]
        };
Console.WriteLine("MC Donald :");
int order1Number = orderingSystem.PlaceOrder("MC Donald", order1Items);

// Display order details
orderingSystem.DisplayOrderDetails(order1Number);

// Place order restaurant 2
var order2Items = new List<MenuItem> {
            restaurant2.Menu[0],
            restaurant2.Menu[1]
        };
Console.WriteLine("\nMie Gacoan :");
int order2Number = orderingSystem.PlaceOrder("Mie Gacoan", order2Items);

// Display order details
orderingSystem.DisplayOrderDetails(order2Number);

// Place order restaurant 3
var order3Items = new List<MenuItem> {
            restaurant3.Menu[0]
        };
Console.WriteLine("\nHolland Bakery :");
int order3Number = orderingSystem.PlaceOrder("Holland Bakery", order3Items);

// Display order details
orderingSystem.DisplayOrderDetails(order3Number);

// Menampilkan Status Orde
Console.WriteLine("\n");
Console.WriteLine("**********************************");
Console.WriteLine(orderingSystem.GetOrderStatus(order1Number));
Console.WriteLine(orderingSystem.GetOrderStatus(order2Number));
Console.WriteLine(orderingSystem.GetOrderStatus(order3Number));
Console.WriteLine("\n");

// Display order details
orderingSystem.DisplayOrderDetails(order1Number);
orderingSystem.DisplayOrderDetails(order2Number);

Console.WriteLine("\n");
// Cancel an order
orderingSystem.CancelOrder(order1Number);

// Display cancel order detail 
orderingSystem.DisplayOrderDetails(order1Number);

// Get order status setelah di cancel
Console.WriteLine(orderingSystem.GetOrderStatus(order1Number));