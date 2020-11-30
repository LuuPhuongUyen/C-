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
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
       string strconn = "database=Northwind;Server=DESKTOP;User id=Uyenpl; password=1234";
        
        private void SuppliersList_Load(object sender, EventArgs e)
        {
            lstvSuppliers.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Suppliers", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string cn = reader.GetString(2);
                string ct = reader.GetString(3);
                string address = reader.GetString(4);
                string city = reader.GetString(5);
                string region = reader.GetSqlString(6).ToString();
                string pc = reader.GetString(7);
                string country = reader.GetString(8);
                string phone = reader.GetString(9);
                string fax = reader.GetSqlString(10).ToString();
                string hp = reader.GetSqlString(11).ToString();

                ListViewItem item = lstvSuppliers.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(cn);
                item.SubItems.Add(ct);
                item.SubItems.Add(address);
                item.SubItems.Add(city);
                item.SubItems.Add(region);
                item.SubItems.Add(pc);
                item.SubItems.Add(country);
                item.SubItems.Add(phone);
                item.SubItems.Add(fax);
                item.SubItems.Add(hp);
            }
            conn.Close();
        }

        private void lstbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstvSuppliers.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Suppliers where CompanyName like '%"+txtName.Text+"%'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string cn = reader.GetString(2);
                string ct = reader.GetString(3);
                string address = reader.GetString(4);
                string city = reader.GetString(5);
                string region = reader.GetSqlString(6).ToString();
                string pc = reader.GetString(7);
                string country = reader.GetString(8);
                string phone = reader.GetString(9);
                string fax = reader.GetSqlString(10).ToString();
                string hp = reader.GetSqlString(11).ToString();

                ListViewItem item = lstvSuppliers.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(cn);
                item.SubItems.Add(ct);
                item.SubItems.Add(address);
                item.SubItems.Add(city);
                item.SubItems.Add(region);
                item.SubItems.Add(pc);
                item.SubItems.Add(country);
                item.SubItems.Add(phone);
                item.SubItems.Add(fax);
                item.SubItems.Add(hp);
            }
            conn.Close();
        }
    }
}
