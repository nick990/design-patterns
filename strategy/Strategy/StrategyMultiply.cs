using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyMultiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
