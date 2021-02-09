using ObserverPattern.Observable;
using ObserverPattern.Observers;
using System;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class FrmManage : Form
    {
        private WeatherStation station;
        private static Random rnd;

        public FrmManage()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void BtnObservable_Click(object sender, EventArgs e)
        {
            station = new WeatherStation();
            BtnObservable.Enabled = false;
            BtnObservador.Enabled = true;
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
            var pcDisplay = new PcDisplay(station);
            station.Add(pcDisplay);
        }

        private void CreateFile()
        {
            var fileDisplay = new FileDisplay(station);
            station.Add(fileDisplay);
        }

        private void CreatePhone()
        {
            var phoneDisplay = new PhoneDisplay(station);
            station.Add(phoneDisplay);
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
