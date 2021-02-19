namespace ObserverPattern.ObserverInterface
{
    public interface IObserver
    {       
        void Update(string tmp);
        void Detach();
    }
}