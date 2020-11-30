using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT_dbConnectSV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string stringconn = "Server=;database=QuanLiSV;user id=uyenlp;password=abcd";
        SqlConnection conn = null;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Lop";
            command.Connection = conn;
            lbDanhSachLop.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string malop = reader.GetString(0).Trim();
                string tenlop = reader.GetString(1);
                int nam = reader.GetInt32(2);
                string line = malop + "-" + tenlop + "-" + nam.ToString();
                lbDanhSachLop.Items.Add(line);
            }
            conn.Close();

        }

        private void lbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDanhSachSV.Items.Clear();
            if (lbDanhSachLop.SelectedIndex == -1) return;
            string line = lbDanhSachLop.SelectedItem.ToString();
            string[] array = line.Split('-');
            string malop = array[0];

            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM SinhVien WHERE Malop=@Malop";
            command.Connection = conn;
            SqlParameter sqlPara = new SqlParameter("@Malop", SqlDbType.Char);
            sqlPara.Value = malop;
            command.Parameters.Add(sqlPara);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malopsv = reader.GetString(2);
                ListViewItem item = lvDanhSachSV.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malopsv);
            }
            conn.Close();
        }

        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
