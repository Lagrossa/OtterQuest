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


            /* Thank you for reading my program. One of my interests is Reverse Engineering. This program displays that in
             * the form of me "hacking" a game. It is called RoboQuest and it is on Steam. I used version 1.6.0-353.
             * A majority of the work put into this project is done externally through software such as Ghidra,
             * Cheat Engine, ProcessHacker, etc. Nonetheless, this program combines my experiences in this class
             * with a fascination that I've always been too afraid to pursue.                                          */

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}