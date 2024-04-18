// See https://aka.ms/new-console-template for more information
using PizzaStore;


Store storeNY = new Store(new NewYorkPizzaFactory());
Store storeChicago = new Store(new ChicagoPizzaFactory());

Console.WriteLine("---------- margherita - NY ----------");
storeNY.OrderPizza("margherita");
Console.WriteLine();
Console.WriteLine("---------- margherita - Chicago ----------");
storeChicago.OrderPizza("margherita");

