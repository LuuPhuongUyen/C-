using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_LT_ThaoTacSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNum_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNum.Text.Trim());
                lbResult.Items.Add(txtNum.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("You must enter number!");
            }
            txtNum.Text = "";
            txtNum.Focus();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            int n = lbResult.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(lbResult.Items[i].ToString()) + 2;
                lbResult.Items.RemoveAt(i);
                lbResult.Items.Insert(i, temp.ToString());
            }
        }

        private void btnFirstEven_Click(object sender, EventArgs e)
        {
            int n = lbResult.Items.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lbResult.Items[i].ToString()) % 2 == 0)
                {
                    string s = lbResult.Items[i].ToString();
                    lbResult.SelectedItem = s;
                    break;
                }
            }

        }

        private void btnLastOdd_Click(object sender, EventArgs e)
        {
            int n = lbResult.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lbResult.Items[i].ToString()) % 2 == 1)
                {
                    string s = lbResult.Items[i].ToString();
                    lbResult.SelectedItem = s;
                    break;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int n = lbResult.SelectedItems.Count;
            for (int i = n - 1; i >= 0; i--)
                lbResult.Items.Remove(lbResult.SelectedItems[i].ToString());
        }

        private void btnDelFirst_Click(object sender, EventArgs e)
        {
            lbResult.Items.Remove(lbResult.Items[0].ToString());
        }

        private void btnDelLast_Click(object sender, EventArgs e)
        {
            int n = lbResult.Items.Count;
            lbResult.Items.Remove(lbResult.Items[n - 1].ToString());
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            Control ctrInteger = (Control)sender;
            if (ctrInteger.Text.Length > 0)
                if (!char.IsDigit(ctrInteger.Text[ctrInteger.Text.Length - 1]))
                    this.errInteger.SetError(ctrInteger, "Please enter integer!");
                else
                    this.errInteger.Clear();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You want to exit?", "Notification", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
