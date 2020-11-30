using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_LT_MDI
{
    public partial class frmChuongtrinhxemphim : Form
    {
        public frmChuongtrinhxemphim()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1, this.Text.Length - 1) +
            this.Text.Substring(0, 1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file| *.avi | MPEG File | *.mpeg | Wav File |*.Wav | Midi File | *.midi | Mp4 File | *.mp4";
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChuongtrinhxemphim_Load(object sender, EventArgs e)
        {
            String s = "Today: " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Time: " +
            DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = s;
        }
    }
}
