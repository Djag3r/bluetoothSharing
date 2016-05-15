using System;
using System.Windows.Forms;
using static System.Diagnostics.Process;

namespace bluetoothSharing
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        public void General_Load(object sender, EventArgs e)
        {
            version.Select();
        }

        public void transfer_Click(object sender, EventArgs e)
        {
            string message = "In the way!";
            MessageBox.Show(message);
            //ofd.ShowDialog();
            version.Select();
        }

        public void gamefunlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Start(@"http://vk.com/gamefun_vk");
            version.Select();
        }

        public void get_Click(object sender, EventArgs e)
        {
            waiting.Visible = true;
            waiting.Enabled = true;
            wait_progressbar.Visible = true;
            wait_progressbar.Enabled = true;
            timer.Start();
            version.Select();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            wait_progressbar.Increment(+1);
            if (wait_progressbar.Value == 100)
            {
                timer.Stop();
                waiting.Text = "Передача файлов не обнаружена!";
            }
        }

        public void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            version.Select();
        }
    }
}
