using ObserverPattern.DisplayInterface;
using ObserverPattern.Observable;
using ObserverPattern.ObserverInterface;
using System.Drawing;

namespace ObserverPattern.Observers
{
    public class FileDisplay : IObserver, IDisplay
    {
        EstacionMeteorologica estacion;
        readonly FrmObserver frm = new FrmObserver();

        public string Temperatura { get; private set; }

        public FileDisplay(EstacionMeteorologica estacion)
        {
            this.estacion = estacion;
            frm.Text = "File Display";
            frm.Show();
        }

        public void Update()
        {
            Temperatura = estacion.GetTemperatura();
            Display();
        }

        public void Display()
        {
            frm.TextBackColor = Color.Black;
            frm.TextForeColor = Color.White;
            frm.DisplayValue = Temperatura;
        }
    }
}