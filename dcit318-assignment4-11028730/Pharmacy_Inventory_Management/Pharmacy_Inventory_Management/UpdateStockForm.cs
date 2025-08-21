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

namespace Pharmacy_Inventory_Management
{
    public partial class UpdateStockForm : Form
    {

        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True";

        public UpdateStockForm()
        {
            InitializeComponent();
        }

        private void UpdateStockForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("GetAllMedicines", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvMedicines.DataSource = dt;
            }
        }

        private void btnUpdateStock_Click_1(object sender, EventArgs e)
        {
            if (dgvMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a medicine first.");
                return;
            }

            int medicineId = Convert.ToInt32(dgvMedicines.SelectedRows[0].Cells["MedicineID"].Value);
            int newQty = int.Parse(txtNewQuantity.Text);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("UpdateStock", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", newQty);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("✅ Stock updated.");
                LoadMedicines();
            }
        }

        
    }
}
