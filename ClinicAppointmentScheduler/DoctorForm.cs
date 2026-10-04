using Microsoft.Data.Sqlite;
using System.Data;
using ClinicAppointmentScheduler.Models;

namespace ClinicAppointmentScheduler
{
    public partial class DoctorForm : Form
    {
        private int selectedDoctorId = 0;

        public DoctorForm()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Doctors";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();

                        table.Load(reader);

                        dgvDoctors.DataSource = table;
                    }
                }
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoctorName.Text))
            {
                MessageBox.Show("Please enter doctor name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Please enter specialization.");
                return;
            }

            try
            {
                Doctor doctor = new Doctor
                {
                    FullName = txtDoctorName.Text,
                    Specialization = txtSpecialization.Text,
                    Phone = txtDoctorPhone.Text
                };

                using (var connection = Database.GetConnection())
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Doctors
                (FullName, Specialization, Phone)
                VALUES
                (@name, @specialization, @phone)";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@name", doctor.FullName);

                        command.Parameters.AddWithValue(
                            "@specialization", doctor.Specialization);

                        command.Parameters.AddWithValue(
                            "@phone", doctor.Phone);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    doctor.GetRoleDescription() +
                    " added successfully.");

                LoadDoctors();
                ClearDoctorFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add doctor.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvDoctors_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvDoctors.Rows[e.RowIndex];

            selectedDoctorId =
                Convert.ToInt32(
                    row.Cells["DoctorId"].Value);

            txtDoctorName.Text =
                row.Cells["FullName"].Value.ToString();

            txtSpecialization.Text =
                row.Cells["Specialization"].Value.ToString();

            txtDoctorPhone.Text =
                row.Cells["Phone"].Value.ToString();
        }

        private void btnUpdateDoctor_Click(
            object sender,
            EventArgs e)
        {
            if (selectedDoctorId == 0)
            {
                MessageBox.Show("Please select a doctor first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDoctorName.Text))
            {
                MessageBox.Show("Please enter doctor name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Please enter specialization.");
                return;
            }

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE Doctors
                    SET FullName = @name,
                        Specialization = @specialization,
                        Phone = @phone
                    WHERE DoctorId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@name",
                        txtDoctorName.Text);

                    command.Parameters.AddWithValue(
                        "@specialization",
                        txtSpecialization.Text);

                    command.Parameters.AddWithValue(
                        "@phone",
                        txtDoctorPhone.Text);

                    command.Parameters.AddWithValue(
                        "@id",
                        selectedDoctorId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Doctor updated successfully.");

            LoadDoctors();

            ClearDoctorFields();

            selectedDoctorId = 0;
        }

        private void btnDeleteDoctor_Click(
            object sender,
            EventArgs e)
        {
            if (selectedDoctorId == 0)
            {
                MessageBox.Show("Please select a doctor first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this doctor?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query =
                    "DELETE FROM Doctors WHERE DoctorId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@id",
                        selectedDoctorId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Doctor deleted successfully.");

            LoadDoctors();

            ClearDoctorFields();

            selectedDoctorId = 0;
        }

        private void btnClearDoctor_Click(
            object sender,
            EventArgs e)
        {
            ClearDoctorFields();
        }

        private void ClearDoctorFields()
        {
            txtDoctorName.Clear();
            txtSpecialization.Clear();
            txtDoctorPhone.Clear();

            selectedDoctorId = 0;

            txtDoctorName.Focus();
        }
    }
}