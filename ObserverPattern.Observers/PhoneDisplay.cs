using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class PhoneDisplay : IObserver, IDisplay
    {
        EstacionMeteorologica estacion;
        readonly FrmObserver frm = new FrmObserver();

        public string Temperatura { get; private set; }

        public PhoneDisplay(EstacionMeteorologica estacion)
        {
            this.estacion = estacion;
            frm.Text = "Phone Display";
            frm.Show();
        }

        public void Update()
        {
            Temperatura = estacion.GetTemperatura();
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