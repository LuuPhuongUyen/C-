using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExamDisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mởFormCapNhatBangDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mởFormTimBangDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void băngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatBangDia f1 = new CapNhatBangDia();
            f1.Show();
        }

        private void tênBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimBangDia f2 = new TimBangDia();
            f2.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
