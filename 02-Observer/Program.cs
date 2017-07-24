using System;
using _02_Observer.Weather;

namespace _02_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var statsDisplay = new StatsDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4M);
            weatherData.SetMeasurements(82, 70, 29.2M);
            weatherData.SetMeasurements(78, 90, 29.2M);

            Console.WriteLine("Hello World!");
        }
    }
}
