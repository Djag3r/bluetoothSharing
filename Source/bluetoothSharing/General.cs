using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluetoothSharing
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            About about = new About(this);
            about.MdiParent = this;
            about.Show();
            //newForm.ShowDialog(); // вызов дочерней формы в виде диалогового окна
        }

        private void General_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
    }
}
