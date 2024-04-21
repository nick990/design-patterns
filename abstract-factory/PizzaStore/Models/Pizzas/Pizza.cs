using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Models.Ingredients;

namespace PizzaStore.Models.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public ICheese Cheese { get; set; }
        public IClams Clams { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IEnumerable<IVeggies> Veggies { get; set; }
        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        override public string ToString()
        {
            string result = "---- " + Name + " ----\n";
            if (Dough != null)
            {
                result += Dough + "\n";
            }
            if (Sauce != null)
            {
                result += Sauce + "\n";
            }
            if (Cheese != null)
            {
                result += Cheese + "\n";
            }
            if (Clams != null)
            {
                result += Clams + "\n";
            }
            if (Veggies != null)
            {
                foreach (IVeggies veggie in Veggies)
                {
                    result += veggie + "\n";
                }
            }
            if (Pepperoni != null)
            {
                result += Pepperoni + "\n";
            }
            return result;
        }
    }
}
