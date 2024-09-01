# Task 7 - Implement Transactions
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/Task7_Preview.PNG)

### Sample Run
![Implement Transactions Sample Run](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/Task7_Preview.gif)

### Details (Task 7 - Implement Transaction)
💡 In this task, you'll implement the Transactions functionality in your ATM console application. Start by creating a data structure, such as a list, to keep track of each transaction (deposits and withdrawals) for each cardholder. Update the DepositCash and WithdrawCash methods to record these transactions. Finally, implement the ShowTransactions method to display the transaction history for the logged-in user.

1. Add a Transaction History Data Structure. Create a list to store transactions for each user.
```csharp
// Dictionary to hold transactions history for each cardholder
static Dictionary<string, List<string>> transactionHistory;
```
A Dictionary is recommended to store transactions because it allows you to efficiently manage and access data. In this case, the Dictionary<string, List<string>> maps each cardholder’s card number (as the key) to a list of their transactions (as the value). This setup makes it easy to quickly find and update the transaction history for any specific cardholder. Using a Dictionary improves performance by providing fast lookups and easy organization of transaction data, ensuring that you can efficiently track and manage each user's transaction history.

2. Update Deposit and Withdrawal Methods. Record each transaction when a deposit or withdrawal is made.
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

                // Record the deposit transaction
                transactionHistory[currentCardNumber].Add($"Deposited: Php {depositAmount}");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid amount. Please enter a positive number.");
    }
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

                    // Record the withdrawal transaction
                    transactionHistory[currentCardNumber].Add($"Withdrew: Php {withdrawAmount}");
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

3. Implement the ShowTransactions Method. Display the transaction history for the logged-in user.

```csharp
// Method to show the transaction history for the logged-in user
public static void ShowTransactions()
{
    if (transactionHistory.ContainsKey(currentCardNumber))
    {
        Console.WriteLine("Transaction History:");
        foreach (var transaction in transactionHistory[currentCardNumber])
        {
            Console.WriteLine(transaction);
        }
    }
    else
    {
        Console.WriteLine("No transactions found.");
    }
}
```
The ShowTransactions method displays the list of transactions for the current cardholder. It first checks if there are any transactions recorded for the cardholder’s card number. If there are, it prints out each transaction from the list. If no transactions are found, it simply shows a message saying "No transactions found."

### ⚡ Key Changes
- [x] transactionHistory Dictionary.
  - [x] Added to store transaction history for each cardholder by their card number.
- [x] InitializeTransactionHistory Method.
  - [x] Initializes the transactionHistory dictionary for each cardholder.
- [x] Updated DepositCash and WithdrawCash Methods.
  - [x] After a deposit or withdrawal, a transaction record is added to the transactionHistory for the current user.
- [x] ShowTransactions Method.
  - [x] Displays the transaction history for the logged-in user, if available.

### Done. 🚀 Congratulations! - Try this challenges and collect 10 trophies 🏆.

- [ ] 🏆 GP1_Challenge1. **Limit PIN Attempts:** Limit the cardholders to enter their PIN a maximum of three times. If the user fails to enter the correct PIN within three attempts, the account should be locked, and the user should not be able to try again until a predefined time has passed.

- [ ] 🏆 🏆 GP1_Challenge2. **Implement Transaction History:** Add functionality to keep track of each transaction (deposit, withdrawal) along with the date and time. Display the last 5 transactions in the "Transactions" menu.

- [ ] 🏆 🏆 GP1_Challenge3. **Daily Withdrawal Limit:** Introduce a daily withdrawal limit for each cardholder. This limit should reset every 24 hours. If the user exceeds this limit, they should be informed and prevented from withdrawing more funds that day.

- [ ] 🏆 🏆 GP1_Challenge4. **Add a Card PIN Change Feature:** Provide a menu option for users to change their PIN after successfully logging in. The new PIN should be verified by re-entering it, and there should be checks to prevent simple or easily guessed PINs.

- [ ] 🏆 🏆 🏆 GP1_Challenge5. **Account Statement Generation:** Add a feature that allows users to generate and view account statements for a specified period. Users should be able to select a date range and receive a summary of all transactions (deposits, withdrawals, transfers) within that period. The statement can be displayed on the screen or saved to a file for future reference.

### Go back to [main page](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/main/README.md)
