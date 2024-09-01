# Task 6 - Implement Withdrawal
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/Task6_Preview.PNG)

### Sample Run
![Implement Withdrawal Sample Run](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/Task6_Preview.gif)

### Details (Task 6 - Implement Withdrawal)
💡 In this task, you will implement the Withdrawal functionality in your ATM console application. First, update the ShowSecureMenu method to add an option for withdrawing cash. Then, implement the WithdrawCash method to handle the withdrawal, check if the user has enough balance, deduct the amount if they do, and provide feedback to the user. With these updates, your ATM console application now supports balance inquiry, cash deposit, and withdrawal functionalities.

1. Update the ShowSecureMenu Method. Add an option for withdrawal.
```csharp
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
``` 
2. Implement the WithdrawCash Method. Create a method to handle the withdrawal, validate the user's balance, and provide feedback.
```csharp
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
                    cardHolders[i] = (cardHolders[i].CardNumber, cardHolders[i].Pin, cardHolders[i].FullName, cardHolders[i].Balance - withdrawAmount);
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
```

### ⚡ Key Changes
- [x] WithdrawCash Method.
  - [x] Prompts the user for an amount to withdraw.
  - [x] Validates the input to ensure it's a positive decimal value.
  - [x] Checks if the logged-in user has sufficient balance.
  - [x] Updates the balance if the withdrawal is successful.
  - [x] Provides feedback on whether the withdrawal was successful or if there were insufficient funds.
- [x] Updated ShowSecureMenu Method.
  - [x] Added a new case ("3") for the Withdrawal option, which calls the WithdrawCash method.

### Next Task
Continue with the last part of this guided project: [Next 7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md)

### Guided Project Tasks

- [ ] [1. Setup Project](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/README.md)
- [ ] [2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)
- [ ] [3. Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/README.md)
- [ ] [4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)
- [ ] [5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)
- [ ] [6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)
- [ ] [7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md) 
