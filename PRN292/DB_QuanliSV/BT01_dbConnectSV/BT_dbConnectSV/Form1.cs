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

namespace BT_dbConnectSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringconn = "Server=;database=QuanLiSV;user id=uyenlp;password=abcd";
        SqlConnection conn = null;
        private void btnSoLuongSV_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM SinhVien";
            command.Connection = conn;
            int kq = (int)command.ExecuteScalar();
            lbSoLuongSV.Text = kq.ToString();
            conn.Close();
        }

        private void btnTTLop_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Lop Where Malop="+"'"+txtNhapMaLop.Text+"'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMaLop.Text = reader.GetString(0);
                txtTenLop.Text= reader.GetString(1);
                txtNam.Text = reader.GetInt32(2).ToString();
            }
            conn.Close();
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            listViewDSSV.Items.Clear();
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM SinhVien WHERE Malop=@Malop";
            SqlParameter sqlPara = new SqlParameter("@Malop", SqlDbType.Char);
            sqlPara.Value = txtNhapMaLop.Text;
            command.Parameters.Add(sqlPara);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maSV = reader.GetString(0);
                string hoten = reader.GetString(1);
                string maLop = reader.GetString(2);
                ListViewItem item = new ListViewItem(maSV);
                item.SubItems.Add(hoten);
                item.SubItems.Add(maLop);
                listViewDSSV.Items.Add(item);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
