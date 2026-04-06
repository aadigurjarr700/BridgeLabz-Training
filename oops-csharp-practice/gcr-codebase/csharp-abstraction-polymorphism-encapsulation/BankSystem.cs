using System;

// Interface for loan-related behavior
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Abstract bank account
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance;

    protected BankAccount(string acc, string name, double bal)
    {
        accountNumber = acc;
        holderName = name;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public abstract double CalculateInterest();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string acc, string name, double bal)
        : base(acc, name, bal) { }

    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Savings loan applied");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5;
    }
}

// Current Account
class CurrentAccount : BankAccount
{
    public CurrentAccount(string acc, string name, double bal)
        : base(acc, name, bal) { }

    public override double CalculateInterest()
    {
        return balance * 0.01;
    }
}

// Main class
class BankSystem
{
    static void Main()
    {
        Console.Write("Enter number of accounts: ");
        int n = int.Parse(Console.ReadLine());

        // array instead of List
        BankAccount[] accounts = new BankAccount[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Account type (Savings/Current): ");
            string type = Console.ReadLine();

            Console.Write("Balance: ");
            double bal = double.Parse(Console.ReadLine());

            if (type == "Savings")
                accounts[i] = new SavingsAccount("S" + i, "User", bal);
            else
                accounts[i] = new CurrentAccount("C" + i, "User", bal);
        }

        // Polymorphic processing
        for (int i = 0; i < accounts.Length; i++)
        {
            Console.WriteLine($"Interest: {accounts[i].CalculateInterest()}");
        }
    }
}
