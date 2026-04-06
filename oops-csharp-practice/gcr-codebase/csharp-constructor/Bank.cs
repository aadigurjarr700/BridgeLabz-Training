using System;

// Parent class
class Bank
{
    public int accountNumber;
    protected string accountHolder = "";
    private double balance;

    public void SetBalance(double b)
    {
        balance = b;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetAccountHolder(string name)
    {
        accountHolder = name;
    }
}

// Child class
class SavingsAccount : Bank
{
    public void DisplayAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder); // protected accessed here
        Console.WriteLine("Balance: " + GetBalance());
    }
}

class Program3
{
    static void Main()
    {
        SavingsAccount acc = new SavingsAccount();

        Console.Write("Enter Account Number: ");
        acc.accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Account Holder: ");
        acc.SetAccountHolder(Console.ReadLine() ?? "");

        Console.Write("Enter Balance: ");
        acc.SetBalance(Convert.ToDouble(Console.ReadLine()));

        acc.DisplayAccount();
    }
}
