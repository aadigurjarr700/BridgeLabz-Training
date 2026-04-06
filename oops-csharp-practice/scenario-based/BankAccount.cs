using System;

// Holds account details
class Account
{
    public string AccountNo;
    public string HolderName;
    public double Balance;
}

// Handles account storage and search
class BankService
{
    Account[] accountList = new Account[10];
    int totalAccounts = 0;

    // Create new account (Manager work)
    public void CreateAccount()
    {
        if (totalAccounts == accountList.Length)
        {
            Console.WriteLine("Maximum account limit reached.");
            return;
        }

        Account acc = new Account();

        Console.Write("Enter Account Number: ");
        acc.AccountNo = Console.ReadLine();

        Console.Write("Enter Account Holder Name: ");
        acc.HolderName = Console.ReadLine();

        Console.Write("Enter Opening Balance: ");
        acc.Balance = Convert.ToDouble(Console.ReadLine());

        accountList[totalAccounts] = acc;
        totalAccounts++;

        Console.WriteLine("Account successfully created.");
    }

    // Search account using account number
    public Account FindAccount(string accNo)
    {
        for (int i = 0; i < totalAccounts; i++)
        {
            if (accountList[i].AccountNo == accNo)
            {
                return accountList[i];
            }
        }
        return null;
    }
}

// User operations
class Customer
{
    BankService bank;

    public Customer(BankService service)
    {
        bank = service;
    }

    public void CustomerMenu()
    {
        Console.Write("Enter your Account Number: ");
        string accNo = Console.ReadLine();

        Account acc = bank.FindAccount(accNo);

        if (acc == null)
        {
            Console.WriteLine("No account found with this number.");
            return;
        }

        int option;
        do
        {
            Console.WriteLine("\n--- CUSTOMER MENU ---");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Logout");
            Console.Write("Choose an option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Current Balance: " + acc.Balance);
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());

                    if (deposit > 0)
                    {
                        acc.Balance += deposit;
                        Console.WriteLine("Amount added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid amount.");
                    }
                    break;

                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());

                    if (withdraw <= 0)
                        Console.WriteLine("Invalid amount entered.");
                    else if (withdraw > acc.Balance)
                        Console.WriteLine("Not enough balance.");
                    else
                    {
                        acc.Balance -= withdraw;
                        Console.WriteLine("Money withdrawn successfully.");
                    }
                    break;

                case 4:
                    Console.WriteLine("You are logged out.");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }

        } while (option != 4);
    }
}

// Manager operations
class Admin
{
    BankService bank;

    public Admin(BankService service)
    {
        bank = service;
    }

    public void AdminMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n--- ADMIN MENU ---");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. View Account Details");
            Console.WriteLine("3. Logout");
            Console.Write("Choose an option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    bank.CreateAccount();
                    break;

                case 2:
                    Console.Write("Enter Account Number: ");
                    string accNo = Console.ReadLine();

                    Account acc = bank.FindAccount(accNo);

                    if (acc == null)
                    {
                        Console.WriteLine("Account does not exist.");
                    }
                    else
                    {
                        Console.WriteLine("Account Holder: " + acc.HolderName);
                        Console.WriteLine("Account Number: " + acc.AccountNo);
                        Console.WriteLine("Balance: " + acc.Balance);
                    }
                    break;

                case 3:
                    Console.WriteLine("Admin logged out.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (option != 3);
    }
}

class Program
{
    static void Main()
    {
        BankService bank = new BankService();
        Admin admin = new Admin(bank);
        Customer customer = new Customer(bank);

        int role;
        do
        {
            Console.WriteLine("\n=== BANK MANAGEMENT SYSTEM ===");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("Select your role: ");

            role = Convert.ToInt32(Console.ReadLine());

            switch (role)
            {
                case 1:
                    admin.AdminMenu();
                    break;

                case 2:
                    customer.CustomerMenu();
                    break;

                case 3:
                    Console.WriteLine("Thank you for using the bank system.");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }

        } while (role != 3);
    }
}
