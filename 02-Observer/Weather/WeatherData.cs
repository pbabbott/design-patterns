using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Observer.Weather
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _Observers;
        private decimal _Temperature;
        private decimal _Humidity;
        private decimal _Pressure;


        public WeatherData()
        {
            this._Observers = new List<IObserver>();
        }


        public void MeasurementsChanged()
        {
            var temp = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            // The display types here are the thing that changes
            // They are not currently encapsulated
            // currentConditionsDisplay.update(temp, humidity, pressure);
            // statisticsDisplay.update(temp, humidity, pressure);
            // forecastDisplay.update(temp, humidity, pressure);
        }

        private decimal GetPressure()
        {
            throw new NotImplementedException();
        }

        private decimal GetHumidity()
        {
            throw new NotImplementedException();
        }

        private decimal GetTemperature()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserver o)
        {
            _Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (_Observers.IndexOf(o) >= 0)
            {
                _Observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (var o in _Observers)
            {
                o.Update(_Temperature, _Humidity, _Pressure);
            }
        }
    }
}