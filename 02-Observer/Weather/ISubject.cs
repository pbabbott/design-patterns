namespace _02_Observer.Weather
{
    public interface ISubject
    {
         void RegisterObserver(IObserver o);
         void RemoveObserver(IObserver o);
         void NotifyObservers();

    }
}