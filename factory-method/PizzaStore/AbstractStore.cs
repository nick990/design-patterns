using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    

    public abstract class AbstractStore
    {
        public abstract Pizza CreatePizza(string type);
        public Pizza OrderPizza(String type) {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
      
    }
}
