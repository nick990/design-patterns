using PizzaStore.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.IngredientsFactory
{
    public class ChicagoPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IEnumerable<IVeggies> CreateVeggies()
        {
            var veggies = new List<IVeggies>
            {
                new BlackOlives(),
                new Spinach(),
                new Eggplant()
            };
            return veggies;
        }
    }
}
