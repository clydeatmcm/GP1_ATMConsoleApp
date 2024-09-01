using System;
using System.Collections.Generic;

namespace Lastname_GP1_ATMConsoleApp_Procedural
{
    internal class Program
    {
        // List of cardholders with demo data
        static List<(string CardNumber, string Pin, string FullName, decimal Balance)> cardHolders;

        // Variable to hold the currently logged-in user's card number
        static string currentCardNumber = string.Empty;

        static void Main(string[] args)
        {
            /* Insert codes from previous task. */
        }

        // Initialize the list of cardholders with demo data
        public static void InitializeCardHolders()
        {
            /* Insert codes from previous task. */
        }

        public static bool Login()
        {
            /* Insert codes from previous task. */
        }

        public static bool ValidateCredentials(string cardNumber, string pin)
        {
            /* Insert codes from previous task. */
        }

        public static void ShowMainMenu()
        {
            /* Insert codes from previous task. */
        }

        public static void ShowSecureMenu()
        {
            bool isLoggedIn = true;

            while (isLoggedIn)
            {
                Console.WriteLine("*--------------------------*");
                Console.WriteLine("| Lastname ATM Secure Menu |");
                Console.WriteLine("|                          |");
                Console.WriteLine("| 1. Balance Enquiry       |");
                Console.WriteLine("| 2. Cash Deposit          |");
                Console.WriteLine("| 3. Withdrawal            |");
                Console.WriteLine("| 4. Transactions          |");
                Console.WriteLine("| 5. Logout                |");
                Console.WriteLine("|                          |");
                Console.WriteLine("*--------------------------*");

                string secureMenuChoice = Console.ReadLine();

                switch (secureMenuChoice)
                {
                    case "1":
                        CheckBalance();  // Call method to check balance
                        break;
                    case "2":
                        DepositCash();  // Call method to deposit cash
                        break;
                    case "3":
                        WithdrawCash();  // Call method to withdraw cash
                        break;
                    case "5":
                        isLoggedIn = false;
                        Console.WriteLine("Logging out...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Method to check and display the balance for the logged-in user
        public static void CheckBalance()
        {
            /* Insert codes from previous task. */
        }

        // Method to deposit cash into the logged-in user's account
        public static void DepositCash()
        {
            /* Insert codes from previous task. */
        }

        // Method to withdraw cash from the logged-in user's account
        public static void WithdrawCash()
        {
            Console.WriteLine("Enter the amount to withdraw:");
            decimal withdrawAmount;
            if (decimal.TryParse(Console.ReadLine(), out withdrawAmount) && withdrawAmount > 0)
            {
                for (int i = 0; i < cardHolders.Count; i++)
                {
                    if (cardHolders[i].CardNumber == currentCardNumber)
                    {
                        if (cardHolders[i].Balance >= withdrawAmount)
                        {
                            cardHolders[i] = (cardHolders[i].CardNumber, cardHolders[i].Pin, 
                                cardHolders[i].FullName, cardHolders[i].Balance - withdrawAmount);
                            Console.WriteLine($"Successfully withdrew: Php {withdrawAmount}");
                            Console.WriteLine($"Your new balance is: Php {cardHolders[i].Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
    }
}
