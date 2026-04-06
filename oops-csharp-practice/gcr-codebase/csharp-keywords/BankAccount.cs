using System;

class BankAccount
{
    // Same bank name for all accounts
    public static string BankName = "Smart Bank";

    // Keeps count of total accounts created
    private static int totalAccounts = 0;

    // Account number should not change once assigned
    public readonly string AccountNumber;

    // Name of account holder
    public string AccountHolderName;

    // Constructor
    public BankAccount(string AccountNumber, string AccountHolderName)
    {
        // 'this' helps differentiate between class fields and parameters
        this.AccountNumber = AccountNumber;
        this.AccountHolderName = AccountHolderName;

        totalAccounts++; // Increase account count
    }

    // Displays account details safely using 'is' operator
    public static void ShowAccountDetails(object obj)
    {
        if (obj is BankAccount account)
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Account Holder: " + account.AccountHolderName);
            Console.WriteLine("Account Number: " + account.AccountNumber);
        }
        else
        {
            Console.WriteLine("This is not a valid bank account.");
        }
    }

    // Displays total number of accounts created
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts in Bank: " + totalAccounts);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Account Number: ");
        string accNo = Console.ReadLine();

        Console.Write("Enter Account Holder Name: ");
        string holderName = Console.ReadLine();

        // Creating account object
        BankAccount account1 = new BankAccount(accNo, holderName);

        // Display account details
        BankAccount.ShowAccountDetails(account1);

        // Show total accounts
        BankAccount.GetTotalAccounts();
    }
}
