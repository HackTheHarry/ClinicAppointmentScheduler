namespace ClinicAppointmentScheduler.Models
{
    public class Patient : Person
    {
        private int age;
        private string gender = string.Empty;
        private string address = string.Empty;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Age must be between 0 and 120.");

                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value?.Trim() ?? string.Empty;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value?.Trim() ?? string.Empty;
            }
        }

        public override string GetRoleDescription()
        {
            return "Patient: " + FullName;
        }
    }
}