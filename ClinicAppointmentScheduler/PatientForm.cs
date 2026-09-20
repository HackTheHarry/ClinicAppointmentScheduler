using Microsoft.Data.Sqlite;
using System.Data;

namespace ClinicAppointmentScheduler
{
    public partial class PatientForm : Form
    {
        private int selectedPatientId = 0;

        public PatientForm()
        {
            InitializeComponent();

            LoadPatients();
        }

        private void LoadPatients()
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Patients";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();

                        table.Load(reader);

                        dvgPatients.DataSource = table;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter patient name.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO Patients
                    (FullName, Age, Gender, Phone, Address)
                    VALUES
                    (@name, @age, @gender, @phone, @address)";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@name", txtName.Text);

                    command.Parameters.AddWithValue(
                        "@age", age);

                    command.Parameters.AddWithValue(
                        "@gender", cmbGender.Text);

                    command.Parameters.AddWithValue(
                        "@phone", txtPhone.Text);

                    command.Parameters.AddWithValue(
                        "@address", txtAddress.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Patient added successfully.");

            LoadPatients();

            ClearFields();
        }

        private void dgvPatients_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dvgPatients.Rows[e.RowIndex];

            selectedPatientId =
                Convert.ToInt32(
                    row.Cells["PatientId"].Value);

            txtName.Text =
                row.Cells["FullName"].Value.ToString();

            txtAge.Text =
                row.Cells["Age"].Value.ToString();

            cmbGender.Text =
                row.Cells["Gender"].Value.ToString();

            if (row != null && row.DataGridView.Columns.Contains("Phone"))
            {
                txtPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
            }

            txtAddress.Text =
                row.Cells["Address"].Value.ToString();
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show(
                    "Please select a patient first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter patient name.");
                return;
            }

            if (!int.TryParse(
                txtAge.Text,
                out int age))
            {
                MessageBox.Show(
                    "Please enter a valid age.");
                return;
            }

            using (var connection =
                Database.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE Patients
                    SET FullName = @name,
                        Age = @age,
                        Gender = @gender,
                        Phone = @phone,
                        Address = @address
                    WHERE PatientId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@name", txtName.Text);

                    command.Parameters.AddWithValue(
                        "@age", age);

                    command.Parameters.AddWithValue(
                        "@gender", cmbGender.Text);

                    command.Parameters.AddWithValue(
                        "@phone", txtPhone.Text);

                    command.Parameters.AddWithValue(
                        "@address", txtAddress.Text);

                    command.Parameters.AddWithValue(
                        "@id", selectedPatientId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Patient updated successfully.");

            LoadPatients();

            ClearFields();

            selectedPatientId = 0;
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (selectedPatientId == 0)
            {
                MessageBox.Show(
                    "Please select a patient first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var connection =
                Database.GetConnection())
            {
                connection.Open();

                string query =
                    "DELETE FROM Patients " +
                    "WHERE PatientId = @id";

                using (var command =
                    new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@id",
                        selectedPatientId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Patient deleted successfully.");

            LoadPatients();

            ClearFields();

            selectedPatientId = 0;
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();

            selectedPatientId = 0;

            txtName.Focus();
        }
    }
}