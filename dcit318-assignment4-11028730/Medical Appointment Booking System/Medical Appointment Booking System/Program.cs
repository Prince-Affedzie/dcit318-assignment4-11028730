using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Appointment_Booking_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicalDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("✅ Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Database connection failed: " + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Start the main form
        }
    }
}
