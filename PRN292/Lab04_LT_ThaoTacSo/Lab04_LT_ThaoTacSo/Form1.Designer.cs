namespace Lab04_LT_ThaoTacSo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlus2 = new System.Windows.Forms.Button();
            this.btnFirstEven = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLastOdd = new System.Windows.Forms.Button();
            this.btnDelLast = new System.Windows.Forms.Button();
            this.btnDelFirst = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.errInteger = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInteger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(103, 18);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(162, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnAddNum
            // 
            this.btnAddNum.Location = new System.Drawing.Point(284, 16);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(75, 23);
            this.btnAddNum.TabIndex = 2;
            this.btnAddNum.Text = "Cập nhật";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 61);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(152, 264);
            this.lbResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelLast);
            this.groupBox1.Controls.Add(this.btnDelFirst);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnLastOdd);
            this.groupBox1.Controls.Add(this.btnFirstEven);
            this.groupBox1.Controls.Add(this.btnPlus2);
            this.groupBox1.Location = new System.Drawing.Point(177, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnPlus2
            // 
            this.btnPlus2.Location = new System.Drawing.Point(16, 30);
            this.btnPlus2.Name = "btnPlus2";
            this.btnPlus2.Size = new System.Drawing.Size(144, 23);
            this.btnPlus2.TabIndex = 0;
            this.btnPlus2.Text = "Tăng mỗi phần tử thêm 2";
            this.btnPlus2.UseVisualStyleBackColor = true;
            this.btnPlus2.Click += new System.EventHandler(this.btnPlus2_Click);
            // 
            // btnFirstEven
            // 
            this.btnFirstEven.Location = new System.Drawing.Point(16, 69);
            this.btnFirstEven.Name = "btnFirstEven";
            this.btnFirstEven.Size = new System.Drawing.Size(144, 23);
            this.btnFirstEven.TabIndex = 1;
            this.btnFirstEven.Text = "Chọn số chẵn đầu";
            this.btnFirstEven.UseVisualStyleBackColor = true;
            this.btnFirstEven.Click += new System.EventHandler(this.btnFirstEven_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(144, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa phần tử đang chọn";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnLastOdd
            // 
            this.btnLastOdd.Location = new System.Drawing.Point(16, 107);
            this.btnLastOdd.Name = "btnLastOdd";
            this.btnLastOdd.Size = new System.Drawing.Size(144, 23);
            this.btnLastOdd.TabIndex = 2;
            this.btnLastOdd.Text = "Chọn số lẻ cuối";
            this.btnLastOdd.UseVisualStyleBackColor = true;
            this.btnLastOdd.Click += new System.EventHandler(this.btnLastOdd_Click);
            // 
            // btnDelLast
            // 
            this.btnDelLast.Location = new System.Drawing.Point(16, 226);
            this.btnDelLast.Name = "btnDelLast";
            this.btnDelLast.Size = new System.Drawing.Size(144, 23);
            this.btnDelLast.TabIndex = 5;
            this.btnDelLast.Text = "Xóa phần tử cuối";
            this.btnDelLast.UseVisualStyleBackColor = true;
            this.btnDelLast.Click += new System.EventHandler(this.btnDelLast_Click);
            // 
            // btnDelFirst
            // 
            this.btnDelFirst.Location = new System.Drawing.Point(16, 187);
            this.btnDelFirst.Name = "btnDelFirst";
            this.btnDelFirst.Size = new System.Drawing.Size(144, 23);
            this.btnDelFirst.TabIndex = 4;
            this.btnDelFirst.Text = "Xóa phần tử đầu";
            this.btnDelFirst.UseVisualStyleBackColor = true;
            this.btnDelFirst.Click += new System.EventHandler(this.btnDelFirst_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 341);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(347, 23);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // errInteger
            // 
            this.errInteger.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 376);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnAddNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errInteger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelLast;
        private System.Windows.Forms.Button btnDelFirst;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLastOdd;
        private System.Windows.Forms.Button btnFirstEven;
        private System.Windows.Forms.Button btnPlus2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ErrorProvider errInteger;
    }
}

