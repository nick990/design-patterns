using PizzaStore.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.IngredientsFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IEnumerable<IVeggies> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
