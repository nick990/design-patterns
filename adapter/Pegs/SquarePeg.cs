using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegs
{
    public class SquarePeg
    {
        private double width;
        public SquarePeg(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
    }
}
