using System;

namespace _02_Observer.Weather
{
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private decimal _Temperature;
        private decimal _Humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_Temperature}F degrees and {_Humidity}% humidity.");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            this._Temperature = temp;
            this._Humidity = humidity;
            this.Display();
        }
    }
}