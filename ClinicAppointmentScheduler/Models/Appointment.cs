namespace ClinicAppointmentScheduler.Models
{
    public class Appointment
    {
        private int appointmentId;
        private int patientId;
        private int doctorId;
        private DateTime appointmentDate;
        private DateTime appointmentTime;
        private string reason = string.Empty;
        private string status = "Scheduled";

        public int AppointmentId
        {
            get { return appointmentId; }
            set { appointmentId = value; }
        }

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }

        public DateTime AppointmentDate
        {
            get { return appointmentDate; }
            set { appointmentDate = value; }
        }

        public DateTime AppointmentTime
        {
            get { return appointmentTime; }
            set { appointmentTime = value; }
        }

        public string Reason
        {
            get { return reason; }
            set
            {
                reason = value?.Trim() ?? string.Empty;
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Appointment status cannot be empty.");

                status = value.Trim();
            }
        }
    }
}