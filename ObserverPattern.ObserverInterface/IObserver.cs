namespace ObserverPattern.ObserverInterface
{
    public interface IObserver
    {
        void Update();
        void Detach();
        string GetTemperature(string temperature);
        void SetTemperature();
        void Notify();
    }
}