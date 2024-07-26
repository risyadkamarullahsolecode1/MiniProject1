// See https://aka.ms/new-console-template for more information

using MiniProject1;

var orderingSystem = new OnlineFoodOrderingSystem();

// Create restaurants
var restaurant1 = new Restaurant("MC Donald");
var restaurant2 = new Restaurant("Pizza Hut");

// Add restaurants to the system
orderingSystem.AddRestaurant(restaurant1);
orderingSystem.AddRestaurant(restaurant2);

// Add menu items to the restaurants
restaurant1.AddMenuItem(new Food("Burger", 40000, "Very spicy Burger", 2));
restaurant1.AddMenuItem(new Dessert("MC Flurry", 20000, "Chocolate Oreo MC Flurry", "High"));
restaurant2.AddMenuItem(new Beverage("Coca Cola", 50000, "Fresh Coca cola", "Large"));

// Place an order
var order1Items = new List<MenuItem> {
            restaurant1.Menu[0], 
            restaurant1.Menu[1]
        };
int order1Number = orderingSystem.PlaceOrder("MC Donald", order1Items);

// Display order details
orderingSystem.DisplayOrderDetails(order1Number);

var order2Items = new List<MenuItem> {
            restaurant2.Menu[0]
        };
int order2Number = orderingSystem.PlaceOrder("Pizza Hut", order2Items);

// Display order details
orderingSystem.DisplayOrderDetails(order2Number);

