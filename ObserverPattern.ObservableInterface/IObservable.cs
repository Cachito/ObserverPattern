using ObserverPattern.ObserverInterface;

namespace ObserverPattern.ObservableInterface
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
