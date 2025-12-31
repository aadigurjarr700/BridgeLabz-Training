using System;

// This class handles invoice-related logic
class InvoiceProcessor
{
    // This method breaks the full invoice line into individual work items
    public string[] ParseInvoice(string invoiceInput)
    {
        // Each task is separated by a comma
        return invoiceInput.Split(',');
    }

    // This method calculates the final payable amount
    public int CalculateTotal(string[] workItems)
    {
        int totalAmount = 0;

        foreach (string item in workItems)
        {
            // Split work name and price
            string[] parts = item.Split('-');

            if (parts.Length == 2)
            {
                // Remove currency text and spaces
                string priceText = parts[1].Replace("INR", "").Trim();
                int price = Convert.ToInt32(priceText);
                totalAmount += price;
            }
        }
        return totalAmount;
    }
}

// This class manages user interaction and menu
class InvoiceApplication
{
    InvoiceProcessor processor = new InvoiceProcessor();

    public void Run()
    {
        int userChoice;

        do
        {
            Console.WriteLine("\n===== INVOICE GENERATOR =====");
            Console.WriteLine("1. Create Invoice");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CreateInvoice();
                    break;

                case 2:
                    Console.WriteLine("Thank you for using the invoice system.");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }

        } while (userChoice != 2);
    }

    // Handles invoice creation
    void CreateInvoice()
    {
        Console.WriteLine("\nEnter work details in this format:");
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");

        string input = Console.ReadLine();

        string[] items = processor.ParseInvoice(input);

        Console.WriteLine("\n----- INVOICE SUMMARY -----");

        foreach (string item in items)
        {
            Console.WriteLine(item.Trim());
        }

        int total = processor.CalculateTotal(items);

        Console.WriteLine("\nTotal Payable Amount: " + total + " INR");
    }
}

// Program execution starts here
class Program
{
    static void Main()
    {
        InvoiceApplication app = new InvoiceApplication();
        app.Run();
    }
}
