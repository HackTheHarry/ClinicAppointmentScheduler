namespace ClinicAppointmentScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
