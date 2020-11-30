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
    public partial class CategoriesList : Form
    {
        public CategoriesList()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=DESKTOP;User id=Uyenpl; password=1234";
        
        private void CategoriesListcs_Load(object sender, EventArgs e)
        {
            lstvCategories.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Categories", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();    
                string name = reader.GetString(1);
                string description = reader.GetString(2);
                
                ListViewItem item = lstvCategories.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(description);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
