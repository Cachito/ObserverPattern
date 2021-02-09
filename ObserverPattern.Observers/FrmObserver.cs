using ObserverPattern.ObserverInterface;
using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern.Observers
{
    public partial class FrmObserver : Form
    {
        public IObserver Observer { set; get; }

        public FrmObserver()
        {
            InitializeComponent();
        }

        public string DisplayType
        {
            set
            {
                TxtDisplayType.Text = value;
            }
        }

        public string DisplayValue
        {
            set
            {
                TxtState.Text = $"Temperature {value}º";
            }
        }

        public Color TextBackColor
        {
            set
            {
                TxtState.BackColor = value;
            }
        }

        public Color TextForeColor
        {
            set
            {
                TxtState.ForeColor = value;
            }
        }

        private void BtnDetach_Click(object sender, System.EventArgs e)
        {
            Observer.Detach();
            Close();
        }
    }
}
