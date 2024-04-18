using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public abstract class Pizza
    {
        public string? Name { get; set; }
        public string? Dough { get; set; }
        public string? Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();


        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Using Dough {Dough}");
            Console.WriteLine($"Using Souce {Sauce}");
            Console.WriteLine("Adding toppings: " + (Toppings.Count == 0 ? "none" : String.Join(", ", Toppings)));

        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25m");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza");
        }
        public void Box()
        {
            Console.WriteLine("Placing Pizza into box");
        }
    }
}
