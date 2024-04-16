using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private double maxTemperature = double.MinValue;
        private double minTemperature = double.MaxValue;
        private double temperatureSum = 0;
        private int numReadings;
        private WeatherData subject;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.subject = weatherData;
            this.subject.RegisterObserver(this);
        }

        public void Update()
        {
            var temperature = this.subject.GetTemperature();
            this.temperatureSum += temperature;
            this.numReadings++;

            if (temperature > this.maxTemperature)
            {
                this.maxTemperature = temperature;
            }

            if (temperature < this.minTemperature)
            {
                this.minTemperature = temperature;
            }

            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"StatisticsDisplay - Avg/Max/Min temperature:\t{this.temperatureSum / this.numReadings:N2}/{this.maxTemperature:N2}/{this.minTemperature:N2}");
        }
    }
}
