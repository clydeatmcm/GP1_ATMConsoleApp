using System;
using System.Collections.Generic;

namespace Lastname_GP1_ATMConsoleApp_Procedural
{
    internal class Program
    {
        static List<(string CardNumber, string Pin, string FullName, decimal Balance)> cardHolders;

        static void Main(string[] args)
        {
            InitializeCardHolders();
            /* Insert codes from previous task. */
        }

        // Initialize the list of cardholders with demo data
        public static void InitializeCardHolders()
        {
            cardHolders = new List<(string, string, string, decimal)>
            {
                ("1234567890123456", "1234", "John Doe", 1000.00m),
                ("2345678901234567", "2345", "Jane Smith", 2000.50m),
                ("3456789012345678", "3456", "Alice Johnson", 1500.75m),
                ("4567890123456789", "4567", "Bob Brown", 3000.00m),
                ("5678901234567890", "5678", "Eve White", 500.25m)
            };
        }

        public static bool Login()
        {
            bool loggedIn = false;

            string mainMenuChoice = Console.ReadLine();
            switch (mainMenuChoice)
            {
                case "1":
                    Console.WriteLine("Please enter your card number:");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine("Please enter your PIN:");
                    string pin = Console.ReadLine();

                    if (ValidateCredentials(cardNumber, pin))
                    {
                        loggedIn = true;
                        Console.WriteLine("Login successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid card number or PIN. Please try again.");
                    }
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

        public static bool ValidateCredentials(string cardNumber, string pin)
        {
            foreach (var cardHolder in cardHolders)
            {
                if (cardHolder.CardNumber == cardNumber && cardHolder.Pin == pin)
                {
                    return true;
                }
            }

            return false;
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
