using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Medical_Appointment_Booking_System
{
    public partial class ManageAppointmentsForm : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicalDB;Integrated Security=True";

        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT a.AppointmentID, d.FullName AS Doctor, p.FullName AS Patient, 
                                        a.AppointmentDate, a.Notes
                                 FROM Appointments a
                                 JOIN Doctors d ON a.DoctorID = d.DoctorID
                                 JOIN Patients p ON a.PatientID = p.PatientID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                // Get values from the selected row
                DataGridViewRow row = dgvAppointments.SelectedRows[0];
                dtpNewDate.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment to delete.");
                return;
            }

            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM Appointments WHERE AppointmentID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", appointmentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("✅ Appointment deleted.");
                LoadAppointments();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment to update.");
                return;
            }

            int appointmentId = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value;
            DateTime newDate = dtpNewDate.Value;
            string newNotes = txtNotes.Text;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Appointments SET AppointmentDate = @Date, Notes = @Notes WHERE AppointmentID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", newDate);
                cmd.Parameters.AddWithValue("@Notes", newNotes);
                cmd.Parameters.AddWithValue("@ID", appointmentId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Appointment updated.");
                    LoadAppointments();
                }
                else
                {
                    MessageBox.Show("❌ Update failed.");
                }
            }
        }
    }
}
