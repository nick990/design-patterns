using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.Behaviors.Fly;
using SimUDuck.Behaviors.Quack;

namespace SimUDuck.Models
{
    public abstract class Duck
    {
        protected IQuackBehavior QuackBehavior;
        protected IFlyBehavior FlyBehavior;

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior FlyBehavior)
        {
            this.FlyBehavior = FlyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior QuackBehavior)
        {
            this.QuackBehavior = QuackBehavior;
        }
    }
}
