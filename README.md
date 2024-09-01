# Task 5 - Implement Cash Deposit
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/Task5_Preview.PNG)

### Sample Run
![Implement Cash Deposit Sample Run](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/Task5_Preview.gif)

### Details (Task 5 - Implement Cash Deposit)
💡 In this task, you will add Cash Deposit functionality to your ATM console application. Start by updating the ShowSecureMenu method to include an option for depositing cash. Next, implement the DepositCash method to handle the deposit, update the user's balance, and provide appropriate feedback. With these changes, the user can log in, check their balance, deposit money, and see the updated balance.

1. Update the ShowSecureMenu Method. Add an option for cash deposit.
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
2. Implement the DepositCash Method. Create a method to handle the deposit, update the user's balance, and provide feedback.
```csharp
// Method to deposit cash into the logged-in user's account
public static void DepositCash()
{
    Console.WriteLine("Enter the amount to deposit:");
    decimal depositAmount;
    if (decimal.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
    {
        for (int i = 0; i < cardHolders.Count; i++)
        {
            if (cardHolders[i].CardNumber == currentCardNumber)
            {
                cardHolders[i] = (cardHolders[i].CardNumber, cardHolders[i].Pin, cardHolders[i].FullName, cardHolders[i].Balance + depositAmount);
                Console.WriteLine($"Successfully deposited: Php {depositAmount}");
                Console.WriteLine($"Your new balance is: Php {cardHolders[i].Balance}");
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
The DepositCash method allows users to deposit money into their account. It prompts the user to enter an amount. If the amount is valid and positive, it updates the balance of the cardholder whose card number matches the current card number. It then displays a success message with the new balance. If the amount is invalid, it shows an error message.

### ⚡ Key Changes
- [x] DepositCash Method.
  - [x] Prompts the user for an amount to deposit.
  - [x] Validates the input to ensure it's a positive decimal value. Updates the balance of the currently logged-in user.
  - [x] Provides feedback on the success of the deposit and shows the new balance.
- [x] Updated ShowSecureMenu Method.
  - [x] Added a new case ("2") for the Cash Deposit option, which calls the DepositCash method.

### Next Task
Continue with the sixth part of this guided project: [Next 6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)

### Guided Project Tasks

- [ ] [1. Setup Project](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/README.md)
- [ ] [2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)
- [ ] [3. Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/README.md)
- [ ] [4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)
- [ ] [5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)
- [ ] [6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)
- [ ] [7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md) 
