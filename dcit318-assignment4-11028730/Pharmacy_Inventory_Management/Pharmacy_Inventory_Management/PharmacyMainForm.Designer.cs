namespace Pharmacy_Inventory_Management
{
    partial class PharmacyMainForm
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
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnSearchMedicine = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnRecordSale = new System.Windows.Forms.Button();
            this.btnViewAllMedicines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Location = new System.Drawing.Point(207, 37);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(132, 47);
            this.btnAddMedicine.TabIndex = 0;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click_1);
            // 
            // btnSearchMedicine
            // 
            this.btnSearchMedicine.Location = new System.Drawing.Point(426, 42);
            this.btnSearchMedicine.Name = "btnSearchMedicine";
            this.btnSearchMedicine.Size = new System.Drawing.Size(132, 42);
            this.btnSearchMedicine.TabIndex = 1;
            this.btnSearchMedicine.Text = "Search Medicine";
            this.btnSearchMedicine.UseVisualStyleBackColor = true;
            this.btnSearchMedicine.Click += new System.EventHandler(this.btnSearchMedicine_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(207, 122);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(132, 39);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnRecordSale
            // 
            this.btnRecordSale.Location = new System.Drawing.Point(207, 211);
            this.btnRecordSale.Name = "btnRecordSale";
            this.btnRecordSale.Size = new System.Drawing.Size(132, 39);
            this.btnRecordSale.TabIndex = 3;
            this.btnRecordSale.Text = "Record Sale";
            this.btnRecordSale.UseVisualStyleBackColor = true;
            this.btnRecordSale.Click += new System.EventHandler(this.btnRecordSale_Click);
            // 
            // btnViewAllMedicines
            // 
            this.btnViewAllMedicines.Location = new System.Drawing.Point(426, 122);
            this.btnViewAllMedicines.Name = "btnViewAllMedicines";
            this.btnViewAllMedicines.Size = new System.Drawing.Size(132, 39);
            this.btnViewAllMedicines.TabIndex = 4;
            this.btnViewAllMedicines.Text = "View All Medicines";
            this.btnViewAllMedicines.UseVisualStyleBackColor = true;
            this.btnViewAllMedicines.Click += new System.EventHandler(this.btnViewAllMedicines_Click);
            // 
            // PharmacyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAllMedicines);
            this.Controls.Add(this.btnRecordSale);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnSearchMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Name = "PharmacyMainForm";
            this.Text = "PharmacyMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnSearchMedicine;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnRecordSale;
        private System.Windows.Forms.Button btnViewAllMedicines;
    }
}