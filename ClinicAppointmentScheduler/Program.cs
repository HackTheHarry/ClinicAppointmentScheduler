using System;
using System.Windows.Forms;

namespace ClinicAppointmentScheduler
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();

                Database.InitializeDatabase();

                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The application encountered an unexpected error.\n\n" +
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}