namespace lab4
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
            this.btnProductsList = new System.Windows.Forms.Button();
            this.btnSuppliersList = new System.Windows.Forms.Button();
            this.btnCategoriesList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProductsList
            // 
            this.btnProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsList.Location = new System.Drawing.Point(76, 113);
            this.btnProductsList.Name = "btnProductsList";
            this.btnProductsList.Size = new System.Drawing.Size(282, 47);
            this.btnProductsList.TabIndex = 4;
            this.btnProductsList.Text = "List all Products";
            this.btnProductsList.UseVisualStyleBackColor = true;
            this.btnProductsList.Click += new System.EventHandler(this.btnProductsList_Click);
            // 
            // btnSuppliersList
            // 
            this.btnSuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliersList.Location = new System.Drawing.Point(76, 207);
            this.btnSuppliersList.Name = "btnSuppliersList";
            this.btnSuppliersList.Size = new System.Drawing.Size(282, 42);
            this.btnSuppliersList.TabIndex = 5;
            this.btnSuppliersList.Text = "List All Suppliers";
            this.btnSuppliersList.UseVisualStyleBackColor = true;
            this.btnSuppliersList.Click += new System.EventHandler(this.btnSuppliersList_Click);
            // 
            // btnCategoriesList
            // 
            this.btnCategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriesList.Location = new System.Drawing.Point(76, 297);
            this.btnCategoriesList.Name = "btnCategoriesList";
            this.btnCategoriesList.Size = new System.Drawing.Size(282, 45);
            this.btnCategoriesList.TabIndex = 6;
            this.btnCategoriesList.Text = "List all Categories";
            this.btnCategoriesList.UseVisualStyleBackColor = true;
            this.btnCategoriesList.Click += new System.EventHandler(this.btnCategoriesList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Northwind";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategoriesList);
            this.Controls.Add(this.btnSuppliersList);
            this.Controls.Add(this.btnProductsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProductsList;
        private System.Windows.Forms.Button btnSuppliersList;
        private System.Windows.Forms.Button btnCategoriesList;
        private System.Windows.Forms.Label label1;
    }
}

