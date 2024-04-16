﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Behaviors.Quack
{
    public class MuteQuak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute...");
        }
    }
}
