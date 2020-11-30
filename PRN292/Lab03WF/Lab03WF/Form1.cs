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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            try
            {
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            int sum = n1 + n2;
            txtResult.Text = sum.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            try
            {
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            int sub = n1 - n2;
            txtResult.Text = sub.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            try
            {
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            int mul = n1 * n2;
            txtResult.Text = mul.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            try
            {
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            float div = (float)n1 / n2;
            txtResult.Text = div.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
