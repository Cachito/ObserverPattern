using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class PhoneDisplay : IObserver, IDisplay
    {
        WeatherStation station;
        readonly FrmObserver frm;

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
            Temperature = station.GetTemperature();
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
    }
}