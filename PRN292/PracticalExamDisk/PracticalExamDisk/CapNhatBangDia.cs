using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalExamDisk
{
    public partial class CapNhatBangDia : Form
    {
        public bool validation()
        {
            if (string.IsNullOrWhiteSpace(txtMaDia.Text) || string.IsNullOrWhiteSpace(txtTenDia.Text) || string.IsNullOrWhiteSpace(txtTheLoai.Text))
            {
                MessageBox.Show("Not empty!");
                return false;
            }
            if (!Regex.Match(txtMaDia.Text, @"[D]\d{4}").Success)
            {
                MessageBox.Show("Mã có dạng D0000", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDia.Focus();
                return false;
            }
            return true;
        }
        public CapNhatBangDia()
        {
            InitializeComponent();
        }
        string stringconn = "Server=;database=QL_BANGDIA;user id=uyenlp;password=abcd";
        SqlConnection conn = null;
        int result = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (!checkIDExist(txtMaDia.Text))
                {
                    if (conn == null) conn = new SqlConnection(stringconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO DIA(MADIA, TENDIA, THELOAI) VALUES (@MADIA, @TENDIA, @THELOAI)";
                    SqlParameter p1 = new SqlParameter("@MADIA", txtMaDia.Text);
                    command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@TENDIA", txtTenDia.Text);
                    command.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@THELOAI", txtTheLoai.Text);
                    command.Parameters.Add(p3);
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Thêm đĩa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\nThêm đĩa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đĩa đã tồn tại");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (checkIDExist(txtMaDia.Text))
                {
                    if (conn == null) conn = new SqlConnection(stringconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "UPDATE DIA SET TENDIA=@TENDIA, THELOAI=@THELOAI WHERE MADIA=@MADIA";
                    SqlParameter p1 = new SqlParameter("@MADIA", txtMaDia.Text);
                    command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@TENDIA", txtTenDia.Text);
                    command.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@THELOAI", txtTheLoai.Text);
                    command.Parameters.Add(p3);
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật đĩa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\nCập nhật đĩa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đĩa không tồn tại");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkIDExist(txtMaDia.Text))
            {
                if (conn == null) conn = new SqlConnection(stringconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "DELETE FROM DIA WHERE MADIA=@MADIA";
                    SqlParameter p1 = new SqlParameter("@MADIA", txtMaDia.Text);
                    command.Parameters.Add(p1);
                try
                {
                    result = command.ExecuteNonQuery();
                    MessageBox.Show("Xóa đĩa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nXóa đĩa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Mã đĩa không tồn tại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool checkIDExist(string madia)
        {
            if (conn == null) conn = new SqlConnection(stringconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DIA where madia=@madia";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@madia", madia);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                conn.Close();
                return false;

            }
            conn.Close();
            return true;
        }
    }
}
