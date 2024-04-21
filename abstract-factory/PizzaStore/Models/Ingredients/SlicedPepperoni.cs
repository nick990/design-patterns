using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Ingredients
{
    public class SlicedPepperoni : IPepperoni
    {
        override public string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
