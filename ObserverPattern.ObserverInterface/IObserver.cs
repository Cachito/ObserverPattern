namespace ObserverPattern.ObserverInterface
{
    public interface IObserver
    {
        void Update();
        void Detach();
    }
}