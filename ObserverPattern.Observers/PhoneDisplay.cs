using System;
using System.Collections.Generic;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class PhoneDisplay : IObserver
    {
        WeatherStation station;
        private readonly FrmObserver frm;
        private string temperature = string.Empty;
        List<IObserver> observers = new List<IObserver>();

        public string Temperature { get; private set; }

        public PhoneDisplay(WeatherStation station)
        {
            this.station = station;

            frm = new FrmObserver
            {
                Observer = this,
                DisplayType = "Phone Display",
                Text = "Phone Display"
            };

            frm.Show();
        }

        public void Update()
        {
            SetTemperature();
            Temperature = GetTemperature(temperature);
            Display();
        }

        public void Display()
        {
            frm.TextBackColor = Color.Red;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = $"{Temperature} °C";
        }

        public void Detach()
        {
            station.Remove(this);
        }

        public string GetTemperature(string temperature)
        {
            SetTemperature();
            return temperature;
        }

        public void SetTemperature()
        {
            temperature = new Random().Next(-301, 301).ToString();
            Notify();
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}