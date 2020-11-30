using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_LT_NhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lsvNhanVien.FullRowSelect = true;
            lsvNhanVien.GridLines = true;
            lsvNhanVien.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtName.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpBirth.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            ListViewItem item = new ListViewItem(txtName.Text.Trim());
            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            item.SubItems.Add(dtpBirth.Value.ToShortDateString());
            try
            {
                int n = int.Parse(txtPhone.Text);
                item.SubItems.Add(txtPhone.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter digit!");
                check = false;
            }
            item.SubItems.Add(txtAddress.Text.Trim());
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please enter address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            if (check == true) { lsvNhanVien.Items.Add(item); }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            }
            foreach (ListViewItem item in lsvNhanVien.Items)
            {
                if (item.Checked)
                    item.Remove();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtName.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpBirth.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
