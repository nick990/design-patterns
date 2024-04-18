﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class MarghetitaPizza :Pizza
    {

        public MarghetitaPizza()
        {
            this.Name = "Margherita";
            this.Dough = "Tradizionale";
            this.Sauce = "Pummarola";
            this.Toppings.Add("Mozzarella");
            this.Toppings.Add("Basilico");
        }


    }
}
