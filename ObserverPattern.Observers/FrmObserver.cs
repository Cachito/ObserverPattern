using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern.Observers
{
    public partial class FrmObserver : Form
    {
        public FrmObserver()
        {
            InitializeComponent();
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
    }
}
