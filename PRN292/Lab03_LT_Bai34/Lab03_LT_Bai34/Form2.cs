﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_LT_Bai34
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }

        private void actionedNumber(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtSecurityCode.Text += b.Text;
        }

        private void btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string data = txtSecurityCode.Text.ToString();
            switch (data)
            {
                case "1645":
                case "1689":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tTechnicians");
                    break;
                case "8345":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tCustodians");
                    break;
                case "9998":
                case "1006":
                case "1008":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tScientist");
                    break;
                default:
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tRestricted Access");
                    break;
            }
            txtSecurityCode.Text = "";
            SaveFile();
        }
        public void SaveFile()
        {
            FileStream fs = new FileStream("D:/C#/PRN292/Lab03_LT_Bai34/Lab03_LT_Bai34/AccessLog.txt", FileMode.Open);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            foreach (string n in lbxAccessLog.Items)
            {
                wr.WriteLine(n);
            }
            wr.Flush();
            fs.Close();
        }

        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
