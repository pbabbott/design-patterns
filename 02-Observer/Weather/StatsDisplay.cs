
using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Observer.Weather
{
    public class StatsDisplay : IDisplay, IObserver
    {
        private List<decimal> _Temperatures = new List<decimal>();

        private ISubject WeatherData;

        public StatsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            var average = _Temperatures.Average();
            var min = _Temperatures.Min();
            var max = _Temperatures.Max();
            Console.WriteLine($"Avg/Max/Min temperature: {average}/{max}/{min}");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            this._Temperatures.Add(temp);
            this.Display();
        }
    }

}