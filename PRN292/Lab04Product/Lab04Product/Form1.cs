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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=DESKTOP;User id=Uyenpl; password=1234";

        private void btnProductsList_Click(object sender, EventArgs e)
        {
            ProductsList p = new ProductsList();
            p.ShowDialog();
        }

        private void btnSuppliersList_Click(object sender, EventArgs e)
        {
            SuppliersList s = new SuppliersList();
            s.ShowDialog();
        }

        private void btnCategoriesList_Click(object sender, EventArgs e)
        {
            CategoriesList c = new CategoriesList();
            c.ShowDialog();
        }
    }
}
