namespace ClinicAppointmentScheduler.Models
{
    public abstract class Person
    {
        private int id;
        private string fullName = string.Empty;
        private string phone = string.Empty;

        public int Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cannot be empty.");

                fullName = value.Trim();
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value?.Trim() ?? string.Empty;
            }
        }

        public abstract string GetRoleDescription();
    }
}
