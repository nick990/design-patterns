// See https://aka.ms/new-console-template for more information
using PizzaStore;


var storeNY = new NewYorkPizzaStore();
var storeChicago = new ChicagoPizzaStore();

Console.WriteLine("---------- margherita - NY ----------");
storeNY.OrderPizza("margherita");
Console.WriteLine();
Console.WriteLine("---------- margherita - Chicago ----------");
storeChicago.OrderPizza("margherita");
Console.WriteLine();
Console.WriteLine("---------- diavola - NY ----------");
storeNY.OrderPizza("diavola");
Console.WriteLine();
Console.WriteLine("---------- diavola - Chicago ----------");
storeChicago.OrderPizza("diavola");

