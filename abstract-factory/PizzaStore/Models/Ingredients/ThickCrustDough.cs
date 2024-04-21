using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Ingredients
{
    public class ThickCrustDough : IDough
    {
        override public string ToString()
        {
            return "Thick Crust Dough";
        }
    }
}
