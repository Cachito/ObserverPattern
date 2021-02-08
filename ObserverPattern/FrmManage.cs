using ObserverPattern.Observable;
using ObserverPattern.Observers;
using System;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class FrmManage : Form
    {
        EstacionMeteorologica estacion;
        private static Random rnd;

        public FrmManage()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void BtnObservable_Click(object sender, EventArgs e)
        {
            estacion = new EstacionMeteorologica();
        }

        private void BtnObservador_Click(object sender, EventArgs e)
        {
            var instanceType = rnd.Next(1, 4);

            switch (instanceType)
            {
                case 1:
                    CreatePhone();
                    break;

                case 2:
                    CreateFile();
                    break;

                default:
                    CreatePc();
                    break;
            }
        }

        private void CreatePc()
        {
            var pd = new PcDisplay(estacion);
            estacion.Add(pd);
        }

        private void CreateFile()
        {
            var fd = new FileDisplay(estacion);
            estacion.Add(fd);
        }

        private void CreatePhone()
        {
            var pd = new PhoneDisplay(estacion);
            estacion.Add(pd);
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
