using SqlForm.Classes;

namespace SqlForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationSettings.LoadSettings();
            ApplicationHistory.LoadHistory();

            TestSql.InitializeTables();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SqlForm());

            ApplicationSettings.WriteSettings();
            ApplicationHistory.WriteHistory();
        }
    }
}