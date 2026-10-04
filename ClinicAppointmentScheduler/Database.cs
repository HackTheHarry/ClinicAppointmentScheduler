using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace ClinicAppointmentScheduler
{
    public static class Database
    {
        private static string databasePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clinic.db");

        private static string connectionString =
            $"Data Source={databasePath}";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string createPatientsTable = @"
                    CREATE TABLE IF NOT EXISTS Patients
                    (
                        PatientId INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Age INTEGER,
                        Gender TEXT,
                        Phone TEXT,
                        Address TEXT
                    )";

                string createDoctorsTable = @"
                    CREATE TABLE IF NOT EXISTS Doctors
                    (
                        DoctorId INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Specialization TEXT,
                        Phone TEXT
                    )";

                string createAppointmentsTable = @"
                    CREATE TABLE IF NOT EXISTS Appointments
                    (
                        AppointmentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        PatientId INTEGER NOT NULL,
                        DoctorId INTEGER NOT NULL,
                        AppointmentDate TEXT NOT NULL,
                        AppointmentTime TEXT NOT NULL,
                        Reason TEXT,
                        Status TEXT,
                        FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
                        FOREIGN KEY (DoctorId) REFERENCES Doctors(DoctorId)
                    )";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createPatientsTable;
                    command.ExecuteNonQuery();

                    command.CommandText = createDoctorsTable;
                    command.ExecuteNonQuery();

                    command.CommandText = createAppointmentsTable;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}