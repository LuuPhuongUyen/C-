namespace Lab04_LT_Bai12DentalPayment
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbClean = new System.Windows.Forms.CheckBox();
            this.lbCleanCost = new System.Windows.Forms.Label();
            this.lbWhiteningCost = new System.Windows.Forms.Label();
            this.cbWhitening = new System.Windows.Forms.CheckBox();
            this.lbXRayCost = new System.Windows.Forms.Label();
            this.cbXRay = new System.Windows.Forms.CheckBox();
            this.lbFilling = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbFillingCost = new System.Windows.Forms.Label();
            this.lbxPayment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(65, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(182, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Dental Payment Form";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(24, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(95, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 21);
            this.txtName.TabIndex = 2;
            // 
            // cbClean
            // 
            this.cbClean.AutoSize = true;
            this.cbClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClean.Location = new System.Drawing.Point(27, 123);
            this.cbClean.Name = "cbClean";
            this.cbClean.Size = new System.Drawing.Size(66, 19);
            this.cbClean.TabIndex = 3;
            this.cbClean.Text = "Cạo vôi";
            this.cbClean.UseVisualStyleBackColor = true;
            // 
            // lbCleanCost
            // 
            this.lbCleanCost.AutoSize = true;
            this.lbCleanCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCleanCost.Location = new System.Drawing.Point(239, 124);
            this.lbCleanCost.Name = "lbCleanCost";
            this.lbCleanCost.Size = new System.Drawing.Size(59, 15);
            this.lbCleanCost.TabIndex = 4;
            this.lbCleanCost.Text = "$100.000";
            // 
            // lbWhiteningCost
            // 
            this.lbWhiteningCost.AutoSize = true;
            this.lbWhiteningCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhiteningCost.Location = new System.Drawing.Point(229, 170);
            this.lbWhiteningCost.Name = "lbWhiteningCost";
            this.lbWhiteningCost.Size = new System.Drawing.Size(69, 15);
            this.lbWhiteningCost.TabIndex = 6;
            this.lbWhiteningCost.Text = "$1.200.000";
            // 
            // cbWhitening
            // 
            this.cbWhitening.AutoSize = true;
            this.cbWhitening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWhitening.Location = new System.Drawing.Point(27, 166);
            this.cbWhitening.Name = "cbWhitening";
            this.cbWhitening.Size = new System.Drawing.Size(76, 19);
            this.cbWhitening.TabIndex = 5;
            this.cbWhitening.Text = "Tẩy trắng";
            this.cbWhitening.UseVisualStyleBackColor = true;
            // 
            // lbXRayCost
            // 
            this.lbXRayCost.AutoSize = true;
            this.lbXRayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXRayCost.Location = new System.Drawing.Point(239, 215);
            this.lbXRayCost.Name = "lbXRayCost";
            this.lbXRayCost.Size = new System.Drawing.Size(59, 15);
            this.lbXRayCost.TabIndex = 8;
            this.lbXRayCost.Text = "$200.000";
            // 
            // cbXRay
            // 
            this.cbXRay.AutoSize = true;
            this.cbXRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXRay.Location = new System.Drawing.Point(27, 211);
            this.cbXRay.Name = "cbXRay";
            this.cbXRay.Size = new System.Drawing.Size(110, 19);
            this.cbXRay.TabIndex = 7;
            this.cbXRay.Text = "Chụp hình răng";
            this.cbXRay.UseVisualStyleBackColor = true;
            // 
            // lbFilling
            // 
            this.lbFilling.AutoSize = true;
            this.lbFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilling.Location = new System.Drawing.Point(24, 264);
            this.lbFilling.Name = "lbFilling";
            this.lbFilling.Size = new System.Drawing.Size(64, 15);
            this.lbFilling.TabIndex = 9;
            this.lbFilling.Text = "Trám răng";
            // 
            // numFilling
            // 
            this.numFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFilling.Location = new System.Drawing.Point(94, 262);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(70, 21);
            this.numFilling.TabIndex = 10;
            this.numFilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(143, 323);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 15);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(198, 320);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(223, 374);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(27, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbFillingCost
            // 
            this.lbFillingCost.AutoSize = true;
            this.lbFillingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFillingCost.Location = new System.Drawing.Point(227, 264);
            this.lbFillingCost.Name = "lbFillingCost";
            this.lbFillingCost.Size = new System.Drawing.Size(71, 15);
            this.lbFillingCost.TabIndex = 15;
            this.lbFillingCost.Text = "$80.000/cái";
            // 
            // lbxPayment
            // 
            this.lbxPayment.FormattingEnabled = true;
            this.lbxPayment.Location = new System.Drawing.Point(325, 64);
            this.lbxPayment.Name = "lbxPayment";
            this.lbxPayment.Size = new System.Drawing.Size(352, 277);
            this.lbxPayment.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(407, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dental Payment Info";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(411, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(522, 374);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 430);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxPayment);
            this.Controls.Add(this.lbFillingCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lbFilling);
            this.Controls.Add(this.lbXRayCost);
            this.Controls.Add(this.cbXRay);
            this.Controls.Add(this.lbWhiteningCost);
            this.Controls.Add(this.cbWhitening);
            this.Controls.Add(this.lbCleanCost);
            this.Controls.Add(this.cbClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox cbClean;
        private System.Windows.Forms.Label lbCleanCost;
        private System.Windows.Forms.Label lbWhiteningCost;
        private System.Windows.Forms.CheckBox cbWhitening;
        private System.Windows.Forms.Label lbXRayCost;
        private System.Windows.Forms.CheckBox cbXRay;
        private System.Windows.Forms.Label lbFilling;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbFillingCost;
        private System.Windows.Forms.ListBox lbxPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

