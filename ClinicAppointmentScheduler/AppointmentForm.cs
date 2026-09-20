using Microsoft.Data.Sqlite;
using System.Data;

namespace ClinicAppointmentScheduler
{
    public partial class AppointmentForm : Form
    {
        private int selectedAppointmentId = 0;

        public AppointmentForm()
        {
            InitializeComponent();

            LoadPatients();
            LoadDoctors();
            LoadStatuses();
            LoadAppointments();
        }

        private void LoadPatients()
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT PatientId, FullName FROM Patients";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();

                        table.Load(reader);

                        cmbPatient.DataSource = table;
                        cmbPatient.DisplayMember = "FullName";
                        cmbPatient.ValueMember = "PatientId";
                    }
                }
            }
        }

        private void LoadDoctors()
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT DoctorId, FullName FROM Doctors";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();

                        table.Load(reader);

                        cmbDoctor.DataSource = table;
                        cmbDoctor.DisplayMember = "FullName";
                        cmbDoctor.ValueMember = "DoctorId";
                    }
                }
            }
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Scheduled");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");

            cmbStatus.SelectedIndex = 0;
        }

        private void LoadAppointments()
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT
                        a.AppointmentId,
                        p.FullName AS Patient,
                        d.FullName AS Doctor,
                        a.AppointmentDate,
                        a.AppointmentTime,
                        a.Reason,
                        a.Status,
                        a.PatientId,
                        a.DoctorId
                    FROM Appointments a
                    INNER JOIN Patients p
                        ON a.PatientId = p.PatientId
                    INNER JOIN Doctors d
                        ON a.DoctorId = d.DoctorId";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();

                        table.Load(reader);

                        dgvAppointments.DataSource = table;
                    }
                }
            }
        }
        private void btnBookAppointment_Click(
    object sender,
    EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            if (cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please enter appointment reason.");
                return;
            }

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO Appointments
                    (
                        PatientId,
                        DoctorId,
                        AppointmentDate,
                        AppointmentTime,
                        Reason,
                        Status
                    )
                    VALUES
                    (
                        @patientId,
                        @doctorId,
                        @date,
                        @time,
                        @reason,
                        @status
                    )";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@patientId",
                        cmbPatient.SelectedValue);

                    command.Parameters.AddWithValue(
                        "@doctorId",
                        cmbDoctor.SelectedValue);

                    command.Parameters.AddWithValue(
                        "@date",
                        dtpDate.Value.ToString("yyyy-MM-dd"));

                    command.Parameters.AddWithValue(
                        "@time",
                        dtpTime.Value.ToString("HH:mm"));

                    command.Parameters.AddWithValue(
                        "@reason",
                        txtReason.Text);

                    command.Parameters.AddWithValue(
                        "@status",
                        cmbStatus.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Appointment booked successfully.");

            LoadAppointments();

            ClearAppointmentFields();
        }
        private void ClearAppointmentFields()
        {
            if (cmbPatient.Items.Count > 0)
                cmbPatient.SelectedIndex = 0;

            if (cmbDoctor.Items.Count > 0)
                cmbDoctor.SelectedIndex = 0;

            dtpDate.Value = DateTime.Today;

            dtpTime.Value = DateTime.Now;

            txtReason.Clear();

            cmbStatus.SelectedIndex = 0;

            selectedAppointmentId = 0;
        }
        private void btnClearAppointment_Click(
    object sender,
    EventArgs e)
        {
            ClearAppointmentFields();
        }
        private void dgvAppointments_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvAppointments.Rows[e.RowIndex];

            selectedAppointmentId =
                Convert.ToInt32(
                    row.Cells["AppointmentId"].Value);

            cmbPatient.SelectedValue =
                Convert.ToInt32(
                    row.Cells["PatientId"].Value);

            cmbDoctor.SelectedValue =
                Convert.ToInt32(
                    row.Cells["DoctorId"].Value);

            dtpDate.Value =
                DateTime.Parse(
                    row.Cells["AppointmentDate"].Value.ToString());

            dtpTime.Value =
                DateTime.Parse(
                    row.Cells["AppointmentTime"].Value.ToString());

            txtReason.Text =
                row.Cells["Reason"].Value.ToString();

            cmbStatus.Text =
                row.Cells["Status"].Value.ToString();
        }
        private void btnUpdateAppointment_Click(
    object sender,
    EventArgs e)
        {
            if (selectedAppointmentId == 0)
            {
                MessageBox.Show(
                    "Please select an appointment first.");

                return;
            }

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE Appointments
                    SET PatientId = @patientId,
                        DoctorId = @doctorId,
                        AppointmentDate = @date,
                        AppointmentTime = @time,
                        Reason = @reason,
                        Status = @status
                    WHERE AppointmentId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@patientId",
                        cmbPatient.SelectedValue);

                    command.Parameters.AddWithValue(
                        "@doctorId",
                        cmbDoctor.SelectedValue);

                    command.Parameters.AddWithValue(
                        "@date",
                        dtpDate.Value.ToString("yyyy-MM-dd"));

                    command.Parameters.AddWithValue(
                        "@time",
                        dtpTime.Value.ToString("HH:mm"));

                    command.Parameters.AddWithValue(
                        "@reason",
                        txtReason.Text);

                    command.Parameters.AddWithValue(
                        "@status",
                        cmbStatus.Text);

                    command.Parameters.AddWithValue(
                        "@id",
                        selectedAppointmentId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Appointment updated successfully.");

            LoadAppointments();

            ClearAppointmentFields();
        }
        private void btnDeleteAppointment_Click(
    object sender,
    EventArgs e)
        {
            if (selectedAppointmentId == 0)
            {
                MessageBox.Show(
                    "Please select an appointment first.");

                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to cancel this appointment?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE Appointments
                    SET Status = 'Cancelled'
                    WHERE AppointmentId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@id",
                        selectedAppointmentId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Appointment cancelled.");

            LoadAppointments();

            ClearAppointmentFields();
        }
    }
}