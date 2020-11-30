using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03WF
{
    public partial class UC_BC : Form
    {
        public UC_BC()
        {
            InitializeComponent();
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else b -= a;
            }
            return a;
        }
        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            try
            {
                n1 = int.Parse(txtA.Text);
                n2 = int.Parse(txtB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            if (rbtnUCLN.Checked)
                txtResult.Text = UCLN(n1, n2).ToString();
            else if (rbtnBCNN.Checked)
                txtResult.Text = BCNN(n1, n2).ToString();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close...");
            Close();
        }
    }
}
