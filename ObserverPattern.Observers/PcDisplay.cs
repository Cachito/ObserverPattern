using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class PcDisplay : IObserver, IDisplay
    {
        WeatherStation station;
        private readonly FrmObserver frm;

        public string Temperature { get; private set; }

        public PcDisplay(WeatherStation station)
        {
            this.station = station;

            frm = new FrmObserver
            {
                Observer = this,
                DisplayType = "PC Display",
                Text = "PC Display"
            };

            frm.Show();
        }

        
        public void Display()
        {
            frm.TextBackColor = Color.Pink;
            frm.TextForeColor = Color.Blue;
            frm.DisplayValue = $"{Temperature} °C";
        }

        public void Detach()
        {
            station.Remove(this);
        }

        public void Update(string tmp)
        {
            Temperature = tmp;
            Display();
        }
    }
}
