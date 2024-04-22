using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Receivers
{
    public class Stereo
    {
        private readonly string location;
        public Stereo(string location)
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine($"Stereo {location} is on");
        }

        public void Off()
        {
            Console.WriteLine($"Stereo {location} is off");
        }

        public void SetCD()
        {
            Console.WriteLine($"Stereo {location} is set for CD input");
        }

        public void SetDVD()
        {
            Console.WriteLine($"Stereo {location} is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine($"Stereo {location} is set for Radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo {location} volume set to {volume}");
        }

        public override string ToString()
        {
            return location;
        }
    }
}
