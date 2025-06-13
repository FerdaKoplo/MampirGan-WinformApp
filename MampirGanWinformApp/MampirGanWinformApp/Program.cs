using MampirGanWinformApp.Views.Forms.Auth;
using MampirGanWinformApp.Views.Forms.Customer;

namespace MampirGanWinformApp
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
            Application.Run(new HomeCustomerPanelForm());
        }
    }
}