using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        public string Name { get; set; }
        public Observer(string name)
        {
            Name = name;
        }
        private int Value;
        public void Update(int state)
        {
            this.Value = state;
            Display();
        }
        private void Display()
        {
            Console.WriteLine($"Observer [{Name}] -> State: {Value}");
        }
    }
}
