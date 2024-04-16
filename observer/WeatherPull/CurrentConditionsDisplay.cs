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
        private WeatherData subject;

        public CurrentConditionsDisplay(WeatherData subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update()
        {
            this.temperature = this.subject.GetTemperature();
            this.humidity = this.subject.GetHumidity();
            this.pressure = this.subject.GetPressure();
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"CurrentConditionsDisplay - Temperature: {this.temperature};\tHumidity: {this.humidity};\tPressure: {this.pressure};");
        }
    }
}
