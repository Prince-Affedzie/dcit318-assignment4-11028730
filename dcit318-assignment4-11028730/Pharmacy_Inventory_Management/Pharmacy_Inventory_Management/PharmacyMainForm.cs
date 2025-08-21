using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Inventory_Management
{
    public partial class PharmacyMainForm : Form
    {
        public PharmacyMainForm()
        {
            InitializeComponent();
        }
        private void btnAddMedicine_Click_1(object sender, EventArgs e)
        {
            AddMedicineForm form = new AddMedicineForm();
            form.ShowDialog();
        }

        private void btnSearchMedicine_Click(object sender, EventArgs e)
        {
            SearchMedicineForm form = new SearchMedicineForm();
            form.ShowDialog();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStockForm form = new UpdateStockForm();
            form.ShowDialog();
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            RecordSaleForm form = new RecordSaleForm();
            form.ShowDialog();
        }

        private void btnViewAllMedicines_Click(object sender, EventArgs e)
        {
            MedicinesListForm form = new MedicinesListForm();
            form.ShowDialog();
        }

       
    }
}
