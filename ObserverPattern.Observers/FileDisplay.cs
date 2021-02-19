using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ObserverPattern.Observers
{
    public class FileDisplay : IObserver
    {
        WeatherStation station;
        private readonly FrmObserver frm;
        private readonly string fileName;
        private readonly string fileFullPath;
        private string temperature = string.Empty;
        List<IObserver> observers = new List<IObserver>();


        public string Temperature { get; private set; }

        public FileDisplay(WeatherStation station)
        {
            this.station = station;

            fileName = $"{Guid.NewGuid()}.txt";
            fileFullPath = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName)}.txt";

            frm = new FrmObserver
            {
                Observer = this,
                DisplayType = "File Display",
                Text = $"{fileName} Display"
            };

            frm.Show();
        }

        public void Update()
        {
            SetTemperature();
            Temperature = GetTemperature(temperature);
            SaveData();
            Display();
        }

        private void SaveData()
        {
            using (StreamWriter sw = File.AppendText(fileFullPath))
            {
                sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} -> {Temperature} °C.");
            }
        }

        public void Display()
        {
            frm.TextBackColor = Color.Black;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = $"actualizado: {Temperature} °C";
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