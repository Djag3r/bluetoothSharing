using System.Windows.Forms;

namespace bluetoothSharing
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, System.EventArgs e)
        {
            visible.Checked = true;
        }
    }
}
