# Task 3 - Populate Demo CardHolders
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/Task3_Preview.PNG)

### Details (Task 3 - Populate Demo CardHolders)
💡 In this task, the ATM console app is updated to include demo CardHolder data. The InitializeCardHolders method creates a list of sample cardholders with card numbers, PINs, names, and balances. This setup allows you to test login and other features with realistic data. The app uses this demo data to validate user credentials during login and manage transactions, ensuring you can effectively demonstrate and test the application's functionality.

1. Replace Code in Program.cs:
  - Add CardHolder List.
 ```csharp
  static List<(string CardNumber, string Pin, string FullName, decimal Balance)> cardHolders;
 ```
  - Initialize CardHolders. Implement the InitializeCardHolders method to populate the cardHolders list with demo data.
```csharp
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
```
The m suffix in 1000.00m indicates that the number is a decimal in C#. The decimal type provides high precision for financial calculations, which is important for applications like ATM systems. Without the m, the number would be treated as a double, which is less precise for handling money.

  - Update the Main Method. Call InitializeCardHolders at the beginning of the Main method to set up the demo data.
```csharp
static void Main(string[] args)
{
    InitializeCardHolders();
    ShowMainMenu();
    if (Login())
    {
        ShowSecureMenu();
    }
}
```
  - Update the Login Method. Modify the Login method to request and validate card number and PIN.
```csharp
public static bool Login()
{
    bool loggedIn = false;

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

    return loggedIn;
}
```
  - Add the ValidateCredentials Method. Implement the ValidateCredentials method to check the entered credentials against the demo data.
```csharp
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
```
2. Complete ShowMainMenu and ShowSecureMenu.
  - Ensure the ShowMainMenu and ShowSecureMenu methods include the menu code from the previous task.
4. Build and Test:
  - Save your changes by clicking File > Save All.
  - Build the project by selecting Build > Build Solution.
  - Run the application by clicking the Start button or pressing F5.
  - Test the login process with demo card numbers and PINs to ensure everything works correctly.

### ⚡ Key Changes
- [x] A list of tuples (string CardNumber, string Pin, string FullName, decimal Balance) is used to represent card holders instead of a class. This keeps the approach procedural.
- [x] InitializeCardHolders method initializes the list of card holders with demo data. This method is called at the start of the Main method.
- [x] The Login method now asks for the card number and PIN and uses the ValidateCredentials method to verify them.
- [x] The ValidateCredentials method checks if the entered card number and PIN match any entry in the cardHolders list.
- [x] The code maintains a procedural structure by using methods to handle functionality instead of relying on class instances.

### Next Task
[Next 4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)

### Guided Project Tasks

- [ ] [1. Setup Project](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/README.md)
- [ ] [2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)
- [ ] [3. Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/README.md)
- [ ] [4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)
- [ ] [5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)
- [ ] [6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)
- [ ] [7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md) 
