namespace Lastname_GP1_ATMConsoleApp_Procedural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
            ShowSecureMenu();
        }

        public static void ShowMainMenu() 
        {
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("| Lastname ATM Main Menu   |");
            Console.WriteLine("|                          |");
            Console.WriteLine("| 1. Insert ATM Card       |");
            Console.WriteLine("| 2. Exit                  |");
            Console.WriteLine("|                          |");
            Console.WriteLine("*--------------------------*");
        }

        public static void ShowSecureMenu()
        {
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("| Lastname ATM Secure Menu |");
            Console.WriteLine("|                          |");
            Console.WriteLine("| 1. Insert ATM Card       |");
            Console.WriteLine("| 2. Exit                  |");
            Console.WriteLine("|                          |");
            Console.WriteLine("*--------------------------*");
        }
    }
}
