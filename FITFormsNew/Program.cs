using FITFormsNew.Asinhrono;
using FITFormsNew.Izvjestaji;
using FITFormsNew.Predavanje_5;
using FITFormsNew.Predavanje_7;

namespace FITFormsNew
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var startnaForma = new frmPing();
            Application.Run(startnaForma );
        }
    }
}