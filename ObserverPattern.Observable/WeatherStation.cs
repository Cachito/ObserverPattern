using ObserverPattern.ObservableInterface;
using ObserverPattern.ObserverInterface;
using System;
using System.Collections.Generic;

namespace ObserverPattern.Observable
{
    public class WeatherStation : IObservable
    {
        readonly FrmObservable frm;

        List<IObserver> observers = new List<IObserver>();
        
        private string temperature = string.Empty;

        public WeatherStation()
        {
            frm = new FrmObservable
            {
                State = "Observable Iniciado",
                Station = this
            };

            frm.Show();
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
            frm.ObserversCount = observers.Count;
        }

        public void Remove(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }

            frm.ObserversCount = observers.Count;
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(temperature);
            }
        }

        public string GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature()
        {
            temperature = new Random().Next(-301, 301).ToString();
            Notify();
        }
    }
}