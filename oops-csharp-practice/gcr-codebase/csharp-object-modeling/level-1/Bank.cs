using System;

class Bank
{
    public string BankName;

    public Bank(string name)
    {
        BankName = name;
    }

    public void OpenAccount(Customer customer)
    {
        Console.WriteLine("\nAccount opened for " + customer.Name + " in " + BankName);
    }
}

class Customer
{
    public string Name;
    private double balance;

    public Customer(string name, double initialBalance)
    {
        Name = name;
        balance = initialBalance;
    }

    public void ViewBalance()
    {
        Console.WriteLine("Current Balance: ₹" + balance);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter bank name: ");
        string bankName = Console.ReadLine();
        Bank bank = new Bank(bankName);

        Console.Write("Enter customer name: ");
        string custName = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        double amount = double.Parse(Console.ReadLine());

        Customer customer = new Customer(custName, amount);

        bank.OpenAccount(customer);
        customer.ViewBalance();
    }
}
