namespace OtterQuest
{
    internal static class Program
    {

        // Is there a downside to doing this instead as opposed to
        // instantiating a new Form every time I swap screens?
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
            Application.Run(new MainMenu());
        }
    }
}