namespace Lastname_GP1_ATMConsoleApp_Procedural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
            if (Login())
            {
                ShowSecureMenu();
            }
        }

        public static bool Login()
        {
            bool loggedIn = false;

            string mainMenuChoice = Console.ReadLine();
            switch(mainMenuChoice)
            {
                case "1": 
                    loggedIn = true; 
                    break;
                case "2": 
                    loggedIn = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            return loggedIn;
        }

        public static void ShowMainMenu() 
        {
            /* Insert codes from previous task. */
        }

        public static void ShowSecureMenu()
        {
            /* Insert codes from previous task. */
        }
    }
}
