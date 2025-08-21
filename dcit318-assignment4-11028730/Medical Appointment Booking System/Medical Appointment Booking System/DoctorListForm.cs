using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Medical_Appointment_Booking_System
{
    public partial class DoctorListForm : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicalDB;Integrated Security=True";

        public DoctorListForm()
        {
            InitializeComponent();
        }

        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDoctors.DataSource = dt;
            }
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
