using Weather;

var weatherData = new WeatherData();
var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);

weatherData.SetMeasuraments(15, 70, 1);
Console.WriteLine();
weatherData.SetMeasuraments(14, 70, 5);
Console.WriteLine();
weatherData.SetMeasuraments(0, 70, 4);
Console.WriteLine();
weatherData.SetMeasuraments(21, 70, 4);