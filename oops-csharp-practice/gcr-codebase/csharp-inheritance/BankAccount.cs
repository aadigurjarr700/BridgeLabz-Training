using System;

// Base class containing common bank account details
class BankAccount
{
    public string AccountNumber; // Stores account number
    public double Balance;       // Stores current balance

    // Initializes base account values
    public BankAccount(string accountNumber,double balance)
    {
        AccountNumber=accountNumber;
        Balance=balance;
    }
}

// Savings account inherits BankAccount
class SavingsAccount:BankAccount
{
    public double InterestRate; // Interest rate for savings

    public SavingsAccount(string accNo,double balance,double interestRate)
        :base(accNo,balance)
    {
        InterestRate=interestRate;
    }

    // Displays savings account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
    }
}

// Checking account inherits BankAccount
class CheckingAccount:BankAccount
{
    public double WithdrawalLimit; // Maximum withdrawal limit

    public CheckingAccount(string accNo,double balance,double limit)
        :base(accNo,balance)
    {
        WithdrawalLimit=limit;
    }

    // Displays checking account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
    }
}

// Fixed deposit account inherits BankAccount
class FixedDepositAccount:BankAccount
{
    public int DepositPeriod; // Deposit duration in months

    public FixedDepositAccount(string accNo,double balance,int period)
        :base(accNo,balance)
    {
        DepositPeriod=period;
    }

    // Displays fixed deposit account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
    }
}

class Program
{
    static void Main()
    {
        // Taking common account input
        Console.Write("Enter account number: ");
        string accNo=Console.ReadLine();

        Console.Write("Enter balance: ");
        double balance=double.Parse(Console.ReadLine());

        Console.Write("Choose account type (savings/checking/fd): ");
        string type=Console.ReadLine().ToLower();

        // Creating object based on selected account type
        if(type=="savings")
        {
            Console.Write("Enter interest rate: ");
            double rate=double.Parse(Console.ReadLine());
            SavingsAccount sa=new SavingsAccount(accNo,balance,rate);
            sa.DisplayAccountType();
        }
        else if(type=="checking")
        {
            Console.Write("Enter withdrawal limit: ");
            double limit=double.Parse(Console.ReadLine());
            CheckingAccount ca=new CheckingAccount(accNo,balance,limit);
            ca.DisplayAccountType();
        }
        else
        {
            Console.Write("Enter deposit period (months): ");
            int period=int.Parse(Console.ReadLine());
            FixedDepositAccount fd=new FixedDepositAccount(accNo,balance,period);
            fd.DisplayAccountType();
        }
    }
}
