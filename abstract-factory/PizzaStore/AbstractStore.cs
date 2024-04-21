using PizzaStore.Models;
using PizzaStore.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    

    public abstract class AbstractStore
    {
        protected abstract Pizza CreatePizza(PizzaType type);
        public Pizza OrderPizza(PizzaType type) {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine($"--- Making a {pizza.Name} ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
      
    }
}
