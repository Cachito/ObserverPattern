using System.Windows.Forms;

namespace ObserverPattern.Observable
{
    public partial class FrmObservable : Form
    {
        public EstacionMeteorologica Estacion{ set; get; }

        public string Estado
        {
            set
            {
                TxtEstado.Text = value;
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
            Estacion.SetTemperatura();
        }
    }
}