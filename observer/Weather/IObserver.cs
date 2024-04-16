namespace Weather
{
    public interface IObserver
    {
        public void Update(double temperature, double humidity, double pressure);
    }
}