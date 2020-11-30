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

namespace Lab03_LT_Bai34
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
                    return "Technicians";
                    break;
                case 8345:
                    return "Custodians";
                    break;
                case 9998:
                case 1006:
                case 1008:
                    return "Scientist";
                    break;
                default:
                    return null;
                    break;
            }
        }
        public void SaveFile()
        {
            StreamWriter write = new StreamWriter(new FileStream("AccessLog.txt", FileMode.Append, FileAccess.Write));
            foreach (var item in lbxAccessLog.Items)
                write.WriteLine(item.ToString());
            write.ToString();
            write.Close();

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtSecurityCode.Text += b.Text;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void lbxAccessLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnSharp_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtSecurityCode.Text);
            string check = checkCode(code);
            if (check == null)
                check = "Restrited Access!";
            lbxAccessLog.Items.Add(DateTime.Now + "\t" + check);
            txtSecurityCode.Text = "";
            SaveFile();
        }

        private void btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSharp_Click(sender, e);
            }
            else
                txtSecurityCode.Text += e.KeyChar.ToString();
        }
    }
}
