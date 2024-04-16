using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public interface ISubject
    {
        public void NotifyObservers();

        public void RemoveObserver(IObserver observer);

        public void RegisterObserver(IObserver observer);
    }
}
