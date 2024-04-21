using PizzaStore.IngredientsFactory;
using PizzaStore.Models;
using PizzaStore.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class ChicagoPizzaStore : AbstractStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientsFactory();
            Pizza pizza;
            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }
            return pizza;
        }
    }
}
