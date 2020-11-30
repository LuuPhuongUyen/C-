namespace BT_dbConnectSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoLuongSV = new System.Windows.Forms.Button();
            this.lbSoLuongSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTTLop = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.listViewDSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXemDSLop = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoLuongSV
            // 
            this.btnSoLuongSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoLuongSV.Location = new System.Drawing.Point(25, 15);
            this.btnSoLuongSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoLuongSV.Name = "btnSoLuongSV";
            this.btnSoLuongSV.Size = new System.Drawing.Size(159, 36);
            this.btnSoLuongSV.TabIndex = 0;
            this.btnSoLuongSV.Text = "Tính số lượng sinh viên";
            this.btnSoLuongSV.UseVisualStyleBackColor = true;
            this.btnSoLuongSV.Click += new System.EventHandler(this.btnSoLuongSV_Click);
            // 
            // lbSoLuongSV
            // 
            this.lbSoLuongSV.AutoSize = true;
            this.lbSoLuongSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongSV.Location = new System.Drawing.Point(202, 25);
            this.lbSoLuongSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuongSV.Name = "lbSoLuongSV";
            this.lbSoLuongSV.Size = new System.Drawing.Size(0, 16);
            this.lbSoLuongSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã lớp";
            // 
            // txtNhapMaLop
            // 
            this.txtNhapMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaLop.Location = new System.Drawing.Point(112, 71);
            this.txtNhapMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapMaLop.Name = "txtNhapMaLop";
            this.txtNhapMaLop.Size = new System.Drawing.Size(146, 23);
            this.txtNhapMaLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã lớp";
            // 
            // btnTTLop
            // 
            this.btnTTLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTLop.Location = new System.Drawing.Point(25, 109);
            this.btnTTLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTTLop.Name = "btnTTLop";
            this.btnTTLop.Size = new System.Drawing.Size(229, 28);
            this.btnTTLop.TabIndex = 5;
            this.btnTTLop.Text = "Xem thông tin chi tiết về lớp";
            this.btnTTLop.UseVisualStyleBackColor = true;
            this.btnTTLop.Click += new System.EventHandler(this.btnTTLop_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(103, 159);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(155, 23);
            this.txtMaLop.TabIndex = 6;
            // 
            // btnDSSV
            // 
            this.btnDSSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSSV.Location = new System.Drawing.Point(361, 19);
            this.btnDSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Size = new System.Drawing.Size(213, 28);
            this.btnDSSV.TabIndex = 7;
            this.btnDSSV.Text = "Xem danh sách sinh viên của lớp";
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            // 
            // listViewDSSV
            // 
            this.listViewDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDSSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDSSV.FullRowSelect = true;
            this.listViewDSSV.GridLines = true;
            this.listViewDSSV.HideSelection = false;
            this.listViewDSSV.Location = new System.Drawing.Point(300, 69);
            this.listViewDSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewDSSV.Name = "listViewDSSV";
            this.listViewDSSV.Size = new System.Drawing.Size(329, 257);
            this.listViewDSSV.TabIndex = 8;
            this.listViewDSSV.UseCompatibleStateImageBehavior = false;
            this.listViewDSSV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sinh viên";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã lớp";
            this.columnHeader3.Width = 90;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(103, 196);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(155, 23);
            this.txtTenLop.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên lớp";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(103, 234);
            this.txtNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(155, 23);
            this.txtNam.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm";
            // 
            // btnXemDSLop
            // 
            this.btnXemDSLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSLop.Location = new System.Drawing.Point(22, 283);
            this.btnXemDSLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemDSLop.Name = "btnXemDSLop";
            this.btnXemDSLop.Size = new System.Drawing.Size(121, 25);
            this.btnXemDSLop.TabIndex = 13;
            this.btnXemDSLop.Text = "Xem danh sách lớp";
            this.btnXemDSLop.UseVisualStyleBackColor = true;
            this.btnXemDSLop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.Location = new System.Drawing.Point(152, 283);
            this.btnQLSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(118, 25);
            this.btnQLSV.TabIndex = 14;
            this.btnQLSV.Text = "Quản lí Sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 343);
            this.Controls.Add(this.btnQLSV);
            this.Controls.Add(this.btnXemDSLop);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewDSSV);
            this.Controls.Add(this.btnDSSV);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.btnTTLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhapMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSoLuongSV);
            this.Controls.Add(this.btnSoLuongSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoLuongSV;
        private System.Windows.Forms.Label lbSoLuongSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTTLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnDSSV;
        private System.Windows.Forms.ListView listViewDSSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXemDSLop;
        private System.Windows.Forms.Button btnQLSV;
    }
}

