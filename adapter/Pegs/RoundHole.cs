using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegs
{
    public class RoundHole
    {
        public double Radius { get; private set; }
        public RoundHole(double radius)
        {
            Radius = radius;
        }

        public bool Fits(IRoundPeg peg)
        {
            return Radius >= peg.GetRadius();
        }
    }
}
