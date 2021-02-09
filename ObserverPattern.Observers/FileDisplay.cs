using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class FileDisplay : IObserver, IDisplay
    {
        WeatherStation station;
        private readonly FrmObserver frm;

        public string Temperature { get; private set; }

        public FileDisplay(WeatherStation station)
        {
            this.station = station;

            frm = new FrmObserver
            {
                Text = "File Display"
            };

            frm.Show();
        }

        public void Update()
        {
            Temperature = station.GetTemperature();
            Display();
        }

        public void Display()
        {
            frm.TextBackColor = Color.Black;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = Temperature;
        }
    }
}