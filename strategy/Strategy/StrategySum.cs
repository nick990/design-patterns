using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategySum : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
    
