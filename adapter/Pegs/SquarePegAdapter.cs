using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegs
{
    public class SquarePegAdapter : IRoundPeg
    {
        private SquarePeg squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
        }

        public double GetRadius()
        {
            return Math.Sqrt(2) / 2 * squarePeg.GetWidth();
        }
    }
}
