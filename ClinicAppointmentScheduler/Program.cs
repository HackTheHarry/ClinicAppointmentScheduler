using System;
using System.Windows.Forms;

namespace ClinicAppointmentScheduler
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Database.InitializeDatabase();

            Application.Run(new MainForm());
        }
    }
}