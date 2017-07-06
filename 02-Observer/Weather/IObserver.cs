namespace _02_Observer.Weather
{
    public interface IObserver
    {
        void Update(decimal temp, decimal humidity, decimal pressure);
    }
}