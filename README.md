# Task 4 - Implement Balance Enquiry
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/Task4_Preview.PNG)

### Sample Run
![Populate Demo CardHolders Sample Run](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/Task4_Preview.gif)

### Details (Task 4 - Implement Balance Enquiry)
To implement the Balance Enquiry task in your C# program, we need to add functionality to the ShowSecureMenu method to allow users to check their balance after logging in.

1. Track the Current User. Store the logged-in cardholder's details so that the balance enquiry is specific to the logged-in user.
```csharp
  // Variable to hold the currently logged-in user's card number
  static string currentCardNumber = string.Empty;
```
2. Modify ShowSecureMenu Method. Add functionality to handle the "Balance Enquiry" option.
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
3. Implement CheckBalance Method. Display the current balance of the logged-in user.
```csharp
// Method to check and display the balance for the logged-in user
public static void CheckBalance()
{
    foreach (var cardHolder in cardHolders)
    {
        if (cardHolder.CardNumber == currentCardNumber)
        {
            Console.WriteLine($"Your current balance is: {cardHolder.Balance:C}");
            break;
        }
    }
}
```

### Next Task
[Next 5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)

### Guided Project Tasks

- [ ] [1. Setup Project](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/README.md)
- [ ] [2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)
- [ ] [3. Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/README.md)
- [ ] [4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)
- [ ] [5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)
- [ ] [6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)
- [ ] [7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md) 
