
public class Sport_Tracker
{
    private List<IObserver> _observers = new List<IObserver>();
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifiyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
        _observers = new List<IObserver>();

    }

    public int Count()
    {
        return _observers.Count();
    }
}
