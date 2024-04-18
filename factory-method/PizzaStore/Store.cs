using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    

    public class Store
    {
        IPizzaFactory Factory;

        public Store(IPizzaFactory factory)
        {
            this.Factory = factory;
        }

        public Pizza OrderPizza(String type) {
            Pizza pizza;

            pizza = Factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
      
    }
}
