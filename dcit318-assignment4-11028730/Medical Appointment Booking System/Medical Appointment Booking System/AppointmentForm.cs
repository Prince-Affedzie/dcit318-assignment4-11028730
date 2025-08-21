using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Appointment_Booking_System
{
    public partial class AppointmentForm : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicalDB;Integrated Security=True";

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();
        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT DoctorID, FullName FROM Doctors WHERE Availability = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDoctors.Items.Add(new { Text = reader["FullName"].ToString(), Value = reader["DoctorID"] });
                }
                conn.Close();
            }
        }

        private void LoadPatients()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT PatientID, FullName FROM Patients";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbPatients.Items.Add(new { Text = reader["FullName"].ToString(), Value = reader["PatientID"] });
                }
                conn.Close();
            }
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedIndex == -1 || cmbPatients.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor and a patient.");
                return;
            }

            dynamic selectedDoctor = cmbDoctors.SelectedItem;
            dynamic selectedPatient = cmbPatients.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes) VALUES (@DoctorID, @PatientID, @Date, @Notes)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", selectedDoctor.Value);
                cmd.Parameters.AddWithValue("@PatientID", selectedPatient.Value);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("✅ Appointment booked successfully!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
