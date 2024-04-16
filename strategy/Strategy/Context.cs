using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            var result = _strategy.Execute(a, b);
            return result;
        }
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
