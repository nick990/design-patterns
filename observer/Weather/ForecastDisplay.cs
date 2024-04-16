using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double currentPressure = 1;
        private double lastPressure;
        private ISubject subject;

        public ForecastDisplay(ISubject subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Display()
        {
            if (this.currentPressure > this.lastPressure)
            {
                Console.WriteLine("ForecastDisplay - Improving weather on the way :) ");
            } else if (this.currentPressure < this.lastPressure)
            {
                Console.WriteLine("ForecastDisplay - Don't forget the umbrella, it's going to rain :( ");
            }
            else
            {
                Console.WriteLine("ForecastDisplay - More of the same :|");
            }
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = pressure;

            this.Display();
        }
    }
}
