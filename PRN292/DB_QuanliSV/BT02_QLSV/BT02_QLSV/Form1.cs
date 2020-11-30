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

namespace BT02_QLSV
{
    public partial class Form1 : Form
    {
        string stringconn = "Server=;database=QuanLiSV;user id=uyenlp;password=abcd";
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM SinhVien", stringconn);
            ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "SinhVien");

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kq = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtMaSV.Text;
            row["Hoten"] = txtHoten.Text;
            row[2] = txtMalop.Text;
            ds.Tables[0].Rows.Add(row);

            try
            {
                kq = adapter.Update(ds, "SinhVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sinh viên không thành công\n" + ex.Message);
            }
            if (kq > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công");
            }
        }
        int vitri = -1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            if (vitri == -1)
            {
                MessageBox.Show("Không có dòng nào được chọn");
                return;
            }
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            txtMaSV.Text = row[0].ToString();
            txtHoten.Text = row["Hoten"].ToString();
            txtMalop.Text = row[2].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (vitri == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào!");
                return;
            }
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            row.BeginEdit();
            row["Masv"] = txtMaSV.Text;
            row["Hoten"] = txtHoten.Text;
            row[2] = txtMalop.Text;
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["SinhVien"]);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (vitri == -1) return;
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            row.Delete();
            int kq = adapter.Update(ds.Tables["SinhVien"]);
            try
            {
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công");
            }
          
        }
    }
}
