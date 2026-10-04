using ClinicAppointmentScheduler.Models;
namespace ClinicAppointmentScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DemonstratePolymorphism();
        }
        private void DemonstratePolymorphism()
        {
            Person patient = new Patient
            {
                FullName = "Sample Patient",
                Age = 30,
                Gender = "Male"
            };

            Person doctor = new Doctor
            {
                FullName = "Sample Doctor",
                Specialization = "General Medicine"
            };

            string patientDescription =
                patient.GetRoleDescription();

            string doctorDescription =
                doctor.GetRoleDescription();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();
        }
    }
}
