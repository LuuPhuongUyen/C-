using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public bool validation()
        {
            if (!Regex.Match(txtName.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (!Regex.Match(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z").Success)
            {
                MessageBox.Show("Invalid Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.Match(txtPhone.Text, @"^[0-9]{10}$-").Success)
            {
                MessageBox.Show("Invalid Phone", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.Parse(txtYear.Text) > 2 || Int32.Parse(txtYear.Text) < 0)
            {
                MessageBox.Show("Limit up to 0-2 years", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.Parse(txtAge.Text) > 90 || Int32.Parse(txtAge.Text) < 0)
            {
                MessageBox.Show("Invalid Age", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadFile()
        {
            string fileName = "Employee.txt";

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');
                    string name = list[0];
                    string age = list[1];
                    string address = list[2];
                    string year = list[3];
                    string phone = list[4];
                    string email = list[5];
                    string date = list[6];
                    ListViewItem item = listView1.Items.Add(name);
                    item.SubItems.Add(age);
                    item.SubItems.Add(address);
                    item.SubItems.Add(year);
                    item.SubItems.Add(phone);
                    item.SubItems.Add(email);
                    item.SubItems.Add(date);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void ReloadFile()
        {
            string fileName = "Employee.txt";

            try
            {
                File.Delete(fileName);
                FileStream fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
                StreamWriter writer = new StreamWriter(fileName);
                foreach (ListViewItem item in listView1.Items)
                {
                    writer.Write(item.Text);
                    for (int i = 1; i < 7; i++)
                    {
                        writer.Write("," + item.SubItems[i].Text);
                    }
                    writer.WriteLine();
                }
                MessageBox.Show("Save File Successfully!");
                writer.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Save File Fail!" + e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtAge.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtYear.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                dtpDate.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string address = txtAddress.Text;
            string year = txtYear.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string date = dtpDate.Text;
            if (validation() == true)
            {
                ListViewItem item = listView1.Items.Add(name);
                item.SubItems.Add(age);
                item.SubItems.Add(address);
                item.SubItems.Add(year);
                item.SubItems.Add(phone);
                item.SubItems.Add(email);
                item.SubItems.Add(date);
                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtYear.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                if ((listView1.SelectedItems.Count) > 0)
                {
                    listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                    listView1.SelectedItems[0].SubItems[1].Text = txtAge.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = txtAddress.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = txtYear.Text;
                    listView1.SelectedItems[0].SubItems[4].Text = txtPhone.Text;
                    listView1.SelectedItems[0].SubItems[5].Text = txtEmail.Text;
                    listView1.SelectedItems[0].SubItems[6].Text = dtpDate.Text;
                }
                else
                {
                    MessageBox.Show("No row is selected!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count) > 0)
            {
                listView1.SelectedItems[0].Remove();
                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtYear.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("No row is selected!");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ReloadFile();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
