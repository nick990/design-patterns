using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class DiavolaPizza :Pizza
    {

        public DiavolaPizza()
        {
            this.Name = "Diavola";
            this.Dough = "Verace";
            this.Sauce = "Piccante";
            this.Toppings.Add("Salame Piccante");
        }


    }
}
