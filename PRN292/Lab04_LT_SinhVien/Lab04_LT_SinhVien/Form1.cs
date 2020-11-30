using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_LT_SinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("Can't be empty!");
            }
            else lbLeft.Items.Add(txtName.Text.Trim());
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            int n = lbLeft.SelectedItems.Count;
            for (int i = 0; i <= n - 1; i++)
                lbRight.Items.Add(lbLeft.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbLeft.Items.RemoveAt(j);
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            int n = lbRight.SelectedItems.Count;
            for (int i = 0; i <= n - 1; i++)
                lbLeft.Items.Add(lbRight.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbRight.Items.RemoveAt(j);
        }

        private void btnAllToRight_Click(object sender, EventArgs e)
        {
            int n = lbLeft.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lbRight.Items.Add(lbLeft.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbLeft.Items.Clear();
        }

        private void btnAllToLeft_Click(object sender, EventArgs e)
        {
            int n = lbRight.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lbLeft.Items.Add(lbRight.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbRight.Items.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbLeft.Items.Remove(lbLeft.SelectedItem);
            lbRight.Items.Remove(lbRight.SelectedItem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
