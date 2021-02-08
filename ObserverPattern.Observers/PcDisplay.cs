using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class PcDisplay : IObserver, IDisplay
    {
        EstacionMeteorologica estacion;
        readonly FrmObserver frm = new FrmObserver();

        public string Temperatura { get; private set; }

        public PcDisplay(EstacionMeteorologica estacion)
        {
            this.estacion = estacion;
            frm.Text = "PC Display";
            frm.Show();
        }

        public void Update()
        {
            Temperatura = estacion.GetTemperatura();
            Display();
        }

        public void Display()
        {
            frm.TextBackColor = Color.Pink;
            frm.TextForeColor = Color.Blue;
            frm.DisplayValue = Temperatura;
        }
    }
}
