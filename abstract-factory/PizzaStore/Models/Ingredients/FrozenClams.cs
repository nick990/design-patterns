using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Ingredients
{
    public class FrozenClams : IClams
    {
        override public string ToString()
        {
            return "Frozen Clams from Chesapeake Bay";
        }
    }
}
