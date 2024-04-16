using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Models
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }


        public override void Display()
        {
            Console.WriteLine("Redhead Duck");
        }
    }
}
