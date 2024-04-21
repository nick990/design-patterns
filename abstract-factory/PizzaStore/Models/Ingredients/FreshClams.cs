using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models.Ingredients
{
    public class FreshClams : IClams
    {
        override public string ToString()
        {
            return "Fresh Clams from Long Island Sound";
        }
    }
}
