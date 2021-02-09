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

        public string Temperatura { get; private set; }

        public PhoneDisplay(WeatherStation station)
        {
            this.station = station;

            frm = new FrmObserver
            {
                Text = "Phone Display"
            };

            frm.Show();
        }

        public void Update()
        {
            Temperatura = station.GetTemperature();
            Display();
        }

        public void Display()
        {
            frm.TextBackColor = Color.Red;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = Temperatura;
        }
    }
}