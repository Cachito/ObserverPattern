using ObserverPattern.ObservableInterface;
using ObserverPattern.ObserverInterface;
using System;
using System.Collections.Generic;

namespace ObserverPattern.Observable
{
    public class EstacionMeteorologica : IObservable
    {        
        FrmObservable frm = new FrmObservable();

        List<IObserver> observers = new List<IObserver>();
        
        private string temperatura = string.Empty;

        public EstacionMeteorologica()
        {
            frm.Estado = "Observable Iniciado";
            frm.Estacion = this;
            frm.Show();
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
            frm.ObserversCount = observers.Count;
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }

        public string GetTemperatura()
        {
            return temperatura;
        }

        public void SetTemperatura()
        {
            temperatura = new Random().Next(-301, 301).ToString();
            Notify();
        }
    }
}