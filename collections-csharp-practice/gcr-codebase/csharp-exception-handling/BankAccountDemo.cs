using System;

class InsufficientFundsException : Exception { }

class BankAccountDemo
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException();

        if (amount > balance)
            throw new InsufficientFundsException();

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}

class BankSystemMain
{
    static void Main()
    {
        BankAccountDemo account = new BankAccountDemo();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amt = double.Parse(Console.ReadLine());

            account.Withdraw(amt);
        }
        catch (InsufficientFundsException)
        {
            Console.WriteLine("Insufficient balance!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}
