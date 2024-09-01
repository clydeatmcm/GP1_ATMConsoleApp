# GP1_ATMConsoleApp
Guided Project 1 - ATM Console App (Procedural)

### Task Preview
![Task 1](./Task1_Preview.PNG)

### Details (Task 1 - Setup Project)
1. Open Visual Studio Community Edition:
  - Launch Visual Studio from your desktop or start menu.
2. Create a New Project:
  - Go to the File menu and select New > Project.
  - In the Create a new project window, choose Console App from the list of templates. Ensure you select C# as the programming language.
  - Click Next.
3. Configure Your Project:
  - Enter a Project name, **Lastname_GP1_ATMConsoleApp_Procedural**.
  - Choose a location to save your project.
  - Click Create.

  ![Setup 1](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/setup_01.PNG)
  
  ![Setup 2](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/setup_02.PNG)

4. Set Up Your Program:
  - Visual Studio will create a default Program.cs file with some starter code.
  - Replace the existing code with the following:
```csharp
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
            Console.WriteLine("| 1. Balance Enquiry       |");
            Console.WriteLine("| 2. Cash Deposit          |");
            Console.WriteLine("| 3. Withdrawal            |");
            Console.WriteLine("| 4. Transactions          |");
            Console.WriteLine("| 5. Logout                |");
            Console.WriteLine("|                          |");
            Console.WriteLine("*--------------------------*");
        }
    }
}
```

5. Build and Run Your Application:
  - Save your changes by clicking File > Save All.
  - To build your project, go to the Build menu and select Build Solution.
  - To run your application, click the Start button (a green play arrow) on the toolbar or press F5 on your keyboard.
6. Test Your Menus:
  - The console window will display your menu options. Ensure the menus appear correctly and verify that the text is displayed as expected.


### Next Task
Continue with the second part of this guided project: [Next 2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)

### Guided Project Tasks

- [ ] [1. Setup Project](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/1.-Setup-Project/README.md)
- [ ] [2. Control Menu Display](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/2.-Control-Menu-Display/README.md)
- [ ] [3. Populate Demo CardHolders](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/3.-Populate-Demo-CardHolders/README.md)
- [ ] [4. Implement Balance Enquiry](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/4.-Implement-Balance-Enquiry/README.md)
- [ ] [5. Implement Cash Deposit](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/5.-Implement-Cash-Deposit/README.md)
- [ ] [6. Implement Withdrawal](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/6.-Implement-Withdrawal/README.md)
- [ ] [7. Implement Transactions](https://github.com/clydeatmcm/GP1_ATMConsoleApp/blob/7.-Implement-Transactions/README.md) 
