using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNum1.Select();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float num1 = 0, num2 = 0;
            try
            {
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            float sum = num1 + num2;
            txtResult.Text = sum.ToString();
            txtNum1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
