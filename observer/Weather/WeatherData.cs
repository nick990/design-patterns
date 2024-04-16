using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class WeatherData : ISubject
    {
        private double temperature;
        private double humidity;
        private double pressure;
        List<IObserver> observers = new List<IObserver>();

        public double GetTemperature() { return temperature; }
        public double GetHumidity() { return humidity; }
        public double GetPressure() { return pressure; }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasuraments(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            this.MeasurementsChanged();
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }


    }
}
