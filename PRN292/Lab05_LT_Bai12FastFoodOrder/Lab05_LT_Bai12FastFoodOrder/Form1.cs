using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_LT_Bai12FastFoodOrder
{
    public partial class Form1 : Form
    {
        public DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void CreateColumn(DataTable tbOrder)
        {
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");
            tbOrder.PrimaryKey = new DataColumn[] { tbOrder.Columns["FoodName"] };
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumn(table);
            dataGridView1.DataSource = table;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool b = false;
            foreach (DataRow s in table.Rows)
                if (btn.Text == s["Foodname"].ToString())
                {
                    s["Quantity"] = int.Parse(s["Quantity"].ToString()) + 1;
                    b = true;
                }
            if (b == false)
            {
                DataRow r = table.NewRow();
                table.Rows.Add(btn.Text, 1);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
                MessageBox.Show("Your order was sent successfully!", "Notification");
            else
                MessageBox.Show("You must choose food!", "Notification");
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var a = dataGridView1.CurrentRow.Cells[0].Value;
                DataRow dr = table.Rows.Find(a);
                if (dr != null)
                {
                    if (int.Parse(dr["Quantity"].ToString()) == 1)
                        table.Rows.Remove(dr);
                    else
                        dr["Quantity"] = int.Parse(dr["Quantity"].ToString()) - 1;
                }
            }
            else
            {
                MessageBox.Show("No food in order list!", "Notification");
            }
        }
    }
}
