using PizzaStore.IngredientsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
