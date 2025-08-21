using System;
using System.Windows.Forms;

namespace Medical_Appointment_Booking_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click_1(object sender, EventArgs e)
        {
            DoctorListForm doctorForm = new DoctorListForm();
            doctorForm.ShowDialog();
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();
        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageForm = new ManageAppointmentsForm();
            manageForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
