using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }


        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}
