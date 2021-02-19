using System.Windows.Forms;

namespace ObserverPattern.Observable
{
    public partial class FrmObservable : Form
    {
        public WeatherStation Station{ set; get; }

        public string State
        {
            set
            {
                TxtState.Text = value;
            }
        }

        public int ObserversCount
        {
            set
            {
                txtObserversCount.Text = $"Observers {value}";
            }
        }

        public FrmObservable()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            Station.SetTemperature();
        }
    }
}