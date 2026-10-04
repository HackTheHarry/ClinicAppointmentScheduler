namespace ClinicAppointmentScheduler.Models
{
    public class Doctor : Person
    {
        private string specialization = string.Empty;

        public string Specialization
        {
            get { return specialization; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Specialization cannot be empty.");

                specialization = value.Trim();
            }
        }

        public override string GetRoleDescription()
        {
            return "Doctor: " + FullName;
        }
    }
}