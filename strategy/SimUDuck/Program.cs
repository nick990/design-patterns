
using SimUDuck.Behaviors.Fly;
using SimUDuck.Models;

Duck mallardDuck = new MallardDuck();
Duck redheadDuck = new RedheadDuck();
Duck rubberDuck = new RubberDuck();

mallardDuck.Display();
mallardDuck.PerformQuack();
mallardDuck.Swim();
mallardDuck.PerformFly();

Console.WriteLine("----------------");

redheadDuck.Display();
redheadDuck.PerformQuack();
redheadDuck.Swim();
redheadDuck.PerformFly();

Console.WriteLine("----------------");

rubberDuck.Display();
rubberDuck.PerformQuack(); 
rubberDuck.Swim();
rubberDuck.PerformFly();
rubberDuck.SetFlyBehavior(new FlyWithRockets());
rubberDuck.PerformFly();