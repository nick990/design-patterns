using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface IPizzaFactory
    {
        Pizza CreatePizza(String type);
    }
}
