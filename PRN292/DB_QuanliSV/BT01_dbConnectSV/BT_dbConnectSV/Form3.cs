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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string stringconn = "Server=;database=QuanLiSV;user id=uyenlp;password=abcd";
        SqlConnection conn = null;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "INSERT INTO SinhVien(Masv, Hoten, Malop) VALUES (@Masv, @Hoten, @Malop)";
            SqlParameter p1 = new SqlParameter("@Masv", txtMaSV.Text);
            command.Parameters.Add(p1);
            SqlParameter p2 = new SqlParameter("@Hoten", txtHoten.Text);
            command.Parameters.Add(p2);
            SqlParameter p3 = new SqlParameter("@Malop", txtMaLop.Text);
            command.Parameters.Add(p3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nThêm sinh viên không thành công");
            }
            if(result > 0)
            {
                HienThiSinhVien();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiSinhVien();
        }
        private void HienThiSinhVien()
        {
            lsvDSSV.Items.Clear();
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM SinhVien",conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()){
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = lsvDSSV.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
            }
            conn.Close();
        }
        int result = -1;

        private void lsvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count > 0)
            {
                txtMaSV.Text = lsvDSSV.SelectedItems[0].SubItems[0].Text.Trim();
                txtHoten.Text = lsvDSSV.SelectedItems[0].SubItems[1].Text.Trim();
                txtMaLop.Text = lsvDSSV.SelectedItems[0].SubItems[2].Text.Trim();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "UPDATE SinhVien SET Hoten=@Hoten, Malop=@Malop WHERE Masv=@Masv";
            SqlParameter p1 = new SqlParameter("@Masv", txtMaSV.Text);
            command.Parameters.Add(p1);
            SqlParameter p2 = new SqlParameter("@Hoten", txtHoten.Text);
            command.Parameters.Add(p2);
            SqlParameter p3 = new SqlParameter("@Malop", txtMaLop.Text);
            command.Parameters.Add(p3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCập nhật sinh viên không thành công");
            }
            if (result > 0)
            {
                HienThiSinhVien();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "DELETE FROM SinhVien WHERE Masv=@Masv";
            SqlParameter p1 = new SqlParameter("@Masv", txtMaSV.Text);
            command.Parameters.Add(p1);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nXóa sinh viên không thành công");
            }
            if (result > 0)
            {
                txtMaSV.Text="";
                txtHoten.Text = "";
                txtMaLop.Text = "";
            }
        }
    }
}
