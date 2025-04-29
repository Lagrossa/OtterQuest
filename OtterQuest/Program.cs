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


            /* Thank you for reading my program. One of my interests is Reverse Engineering. This program displays that in
             * the form of me "hacking" a game. It is called RoboQuest and it is on Steam. I used version 1.6.0-353.
             * A majority of the work put into this project is done externally through software such as Ghidra,
             * Cheat Engine, ProcessHacker, etc. Nonetheless, this program combines my experiences in this class
             * with a fascination that I've always been too intimidated by to pursue.                                   */

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}