using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private ISubject subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"CurrentConditionsDisplay - Temperature: {this.temperature};\tHumidity: {this.humidity};\tPressure: {this.pressure};");
        }
    }
}
