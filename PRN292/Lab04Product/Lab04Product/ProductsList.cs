using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=DESKTOP;User id=Uyenpl; password=1234";
       

        private void ProductsList_Load(object sender, EventArgs e)
        {
            lstvProducts.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Products", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string si = reader.GetInt32(2).ToString();
                string cid = reader.GetInt32(3).ToString();
                string qpu = reader.GetString(4);
                string up = reader.GetDecimal(5).ToString();
                string uis = reader.GetInt16(6).ToString();
                string uoo = reader.GetInt16(7).ToString();
                string rl = reader.GetInt16(8).ToString();
                string dis = reader.GetBoolean(9).ToString();

                ListViewItem item = lstvProducts.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(si);
                item.SubItems.Add(cid);
                item.SubItems.Add(qpu);
                item.SubItems.Add(up);
                item.SubItems.Add(uis);
                item.SubItems.Add(uoo);
                item.SubItems.Add(rl);
                item.SubItems.Add(dis);
            }
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstvProducts.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Products where ProductName like '%" + txtName.Text + "%'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string si = reader.GetInt32(2).ToString();
                string cid = reader.GetInt32(3).ToString();
                string qpu = reader.GetString(4);
                string up = reader.GetDecimal(5).ToString();
                string uis = reader.GetInt16(6).ToString();
                string uoo = reader.GetInt16(7).ToString();
                string rl = reader.GetInt16(8).ToString();
                string dis = reader.GetBoolean(9).ToString();

                ListViewItem item = lstvProducts.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(si);
                item.SubItems.Add(cid);
                item.SubItems.Add(qpu);
                item.SubItems.Add(up);
                item.SubItems.Add(uis);
                item.SubItems.Add(uoo);
                item.SubItems.Add(rl);
                item.SubItems.Add(dis);
            }
            conn.Close();
        }
    }
}
