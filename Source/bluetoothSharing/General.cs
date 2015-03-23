using System;
using System.Windows.Forms;
using System.Diagnostics;

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
            Button btn = sender as Button;
            groupbox.Visible = true;
            namelabel.Visible = true;
            versionlabel.Visible = true;
            buildlabel.Visible = true;
            gamefunlinklabel.Visible = true;
            datelabel.Visible = true;
            btn.Click -= new EventHandler(infobutton_Click);
            btn.Click += new EventHandler(infobutton_Click_1);
        }

        private void infobutton_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            groupbox.Visible = false;
            namelabel.Visible = false;
            versionlabel.Visible = false;
            buildlabel.Visible = false;
            gamefunlinklabel.Visible = false;
            datelabel.Visible = false;
            btn.Click -= new EventHandler(infobutton_Click_1);
            btn.Click += new EventHandler(infobutton_Click);
        }

        private void gamefunlinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://vk.com/gamefun_vk");
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
