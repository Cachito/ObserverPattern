using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System;
using System.Drawing;
using System.IO;

namespace ObserverPattern.Observers
{
    public class FileDisplay : IObserver, IDisplay
    {
        WeatherStation station;
        private readonly FrmObserver frm;
        private readonly string fileName;
        private readonly string fileFullPath;

        private string temperature;
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

        public void Update(string temperature)
        {
            this.temperature = temperature;
            SaveData();
            Display();
        }

        private void SaveData()
        {
            using (StreamWriter sw = File.AppendText(fileFullPath))
            {
                sw.WriteLine($"{DateTime.Now:dd/MM/yyyy HH:mm:ss} -> {temperature} °C.");
            }
        }

        public void Display()
        {
            frm.TextBackColor = Color.Black;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = $"actualizado: {temperature} °C";
        }

        public void Detach()
        {
            station.Remove(this);
        }
    }
}