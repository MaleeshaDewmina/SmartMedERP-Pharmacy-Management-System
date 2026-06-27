using System;
using System.Windows.Forms;
using SmartMed.Forms;

namespace SmartMedERP
{
    /*
     * Application startup class.
     * This class contains the main entry point of the SmartMed ERP system.
     */
    internal static class Program
    {
        /*
         * Main method starts the Windows Forms application.
         * The application begins by opening the LoginForm.
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the system from the login screen.
            Application.Run(new LoginForm());
        }
    }
}