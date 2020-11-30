using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_LT_Bai34_Security
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string checkCode(int code)
        {
            switch (code)
            {
                case 1645:
                case 1689:
                    return "\tTechnicians";
                    break;
                case 8345:
                    return "\tCustodians";
                    break;
                case 9998:
                case 1006:
                case 1008:
                    return "\tScientist";
                    break;
                default:
                    return "\tRestricted Access";
                    break;
            }
        }
        private void SaveFile()
        {
            FileStream fs = new FileStream("D:/C#/PRN292/Lab03_LT_Bai34_Security/Lab03_LT_Bai34_Security/AccessLog.txt", FileMode.Open);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            foreach (string n in lbxAccessLog.Items)
            {
                wr.WriteLine(n);
            }
            wr.Flush();
            fs.Close();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int code = 0;
            try
            {
                 code = int.Parse(txtSecurityCode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number!");
            }
            string check = checkCode(code);
            lbxAccessLog.Items.Add(DateTime.Now + check);
            txtSecurityCode.Text = "";
            SaveFile();
        }

        private void numClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtSecurityCode.Text += b.Text;
        }

        private void numKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCheck_Click(sender, e);
            }
            else
                txtSecurityCode.Text += e.KeyChar.ToString();
        }
    }
}
