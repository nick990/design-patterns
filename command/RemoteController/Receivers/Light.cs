using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Receivers
{

    public class Light
    {
        private readonly string location;
        public Light(string location)
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine($"Light {location} is on");
        }

        public void Off()
        {
            Console.WriteLine($"Light {location} is off");
        }
        public override string ToString()
        {
            return location;
        }
    }
}
