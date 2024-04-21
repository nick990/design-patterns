using PizzaStore.IngredientsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _ingredientFactory = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clams = _ingredientFactory.CreateClams();
        }
    }
}
