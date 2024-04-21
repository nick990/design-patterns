using PizzaStore;
using PizzaStore.Models.Pizzas;

Pizza pizza;
var nyStore = new NewYorkPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

pizza = nyStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza =chicagoStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = nyStore.OrderPizza(PizzaType.Clam);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = chicagoStore.OrderPizza(PizzaType.Clam);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = nyStore.OrderPizza(PizzaType.Pepperoni);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = chicagoStore.OrderPizza(PizzaType.Pepperoni);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = nyStore.OrderPizza(PizzaType.Veggie);
Console.WriteLine(pizza);
Console.WriteLine("\n");
pizza = chicagoStore.OrderPizza(PizzaType.Veggie);
Console.WriteLine(pizza);
Console.WriteLine("\n");

