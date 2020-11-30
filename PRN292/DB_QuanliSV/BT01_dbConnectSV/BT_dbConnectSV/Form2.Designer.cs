namespace BT_dbConnectSV
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDanhSachLop = new System.Windows.Forms.ListBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách Sinh viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbDanhSachLop
            // 
            this.lbDanhSachLop.FormattingEnabled = true;
            this.lbDanhSachLop.Location = new System.Drawing.Point(11, 63);
            this.lbDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.lbDanhSachLop.Name = "lbDanhSachLop";
            this.lbDanhSachLop.Size = new System.Drawing.Size(185, 199);
            this.lbDanhSachLop.TabIndex = 2;
            this.lbDanhSachLop.SelectedIndexChanged += new System.EventHandler(this.lbDanhSachLop_SelectedIndexChanged);
            // 
            // lvDanhSachSV
            // 
            this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDanhSachSV.FullRowSelect = true;
            this.lvDanhSachSV.GridLines = true;
            this.lvDanhSachSV.HideSelection = false;
            this.lvDanhSachSV.Location = new System.Drawing.Point(219, 63);
            this.lvDanhSachSV.Margin = new System.Windows.Forms.Padding(2);
            this.lvDanhSachSV.Name = "lvDanhSachSV";
            this.lvDanhSachSV.Size = new System.Drawing.Size(323, 199);
            this.lvDanhSachSV.TabIndex = 3;
            this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
            this.lvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sinh Viên";
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
            this.columnHeader3.Width = 80;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 292);
            this.Controls.Add(this.lvDanhSachSV);
            this.Controls.Add(this.lbDanhSachLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDanhSachLop;
        private System.Windows.Forms.ListView lvDanhSachSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}