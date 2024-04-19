using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class ChicagoPizzaStore : AbstractStore
    {
        public override Pizza CreatePizza(String type)
        {
    
            Pizza pizza;

            switch (type)
            {
                case "margherita":
                    pizza = new MarghetitaPizza();
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
