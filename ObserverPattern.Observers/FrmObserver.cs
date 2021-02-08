using System.Drawing;
using System.Windows.Forms;

namespace ObserverPattern.Observers
{
    public partial class FrmObserver : Form
    {
        public string DisplayValue
        {
            set
            {
                TxtEstado.Text = $"Temperatura {value}º";
            }
        }

        public Color TextBackColor
        {
            set
            {
                TxtEstado.BackColor = value;
            }
        }

        public Color TextForeColor
        {
            set
            {
                TxtEstado.ForeColor = value;
            }
        }

        public FrmObserver()
        {
            InitializeComponent();
        }
    }
}
