using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private int State;
        private List<IObserver> Observers = new List<IObserver>();
        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(State);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void SetState(int state)
        {
            this.State = state;
            NotifyObservers();
        }
        public int GetState()
        {
            return this.State;
        }
    }
}
