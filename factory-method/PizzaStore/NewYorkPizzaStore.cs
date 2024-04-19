using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class NewYorkPizzaStore : AbstractStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;

            switch (type)
            {
                case "margherita":
                    pizza = new MarghetitaNYPizza();
                    break;
                case "diavola":
                    pizza = new DiavolaPizza();
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }

            return pizza;
        }
    }
}
