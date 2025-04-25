namespace OtterQuest
{
    internal static class Program
    {

        // Not sure if there was another way to do this...
        // I intuit that this may be plebian.
        internal static List<Form> forms = new List<Form>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}