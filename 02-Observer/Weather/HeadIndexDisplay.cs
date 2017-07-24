
using System;
using System.Linq;

namespace _02_Observer.Weather
{
    public class HeatIndexDisplay : IDisplay, IObserver
    {
        private double _HeatIndex;
        private ISubject WeatherData;

        public HeatIndexDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        private double ComputeHeatIndex(double t, double rh)
        {
            return (double)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
        }

        public void Display()
        {
            Console.WriteLine($"Heat Index {_HeatIndex}.");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            var t = Convert.ToDouble(temp);
            var rh = Convert.ToDouble(humidity);
            _HeatIndex = this.ComputeHeatIndex(t, rh);

            this.Display();
        }
    }

}