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

namespace Lab04_LT_Bai12DentalPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void getPay()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float total = 0;
                if (cbClean.Checked) 
                    total += 100000;
                if (cbWhitening.Checked)
                    total += 1200000;
                if (cbXRay.Checked)
                    total += 200000;
                float count = Convert.ToInt32(numFilling.Value);
                total += count * 80000;
                txtTotal.Text = "$" + total.ToString();
                lbxPayment.Items.Add(txtName.Text + " - " + txtTotal.Text);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            getPay();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                FileStream fs = new FileStream("D:/C#/PRN292/Lab04_LT_Bai12DentalPayment/Lab04_LT_Bai12DentalPayment/BillList.txt", FileMode.Create);
                StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
                foreach (string item in lbxPayment.Items)
                {
                    wr.WriteLine(item);
                }
                wr.Flush();
                fs.Close();
            }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:/C#/PRN292/Lab04_LT_Bai12DentalPayment/Lab04_LT_Bai12DentalPayment/BillList.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string item = rd.ReadToEnd();
            lbxPayment.Items.Add(item);
            rd.Close();
        }
    }
}
