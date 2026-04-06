using System;

class Product
{
    // Discount percentage shared by all products
    public static double Discount = 10; // default discount

    // Readonly product ID (cannot be modified)
    public readonly int ProductID;

    // Product details
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor to initialize product details
    public Product(int ProductID, string ProductName, double Price, int Quantity)
    {
        // Using 'this' keyword for clarity
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    // Static method to update discount value
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount updated to " + Discount + "%");
    }

    // Method to calculate final price after discount
    public double CalculateFinalPrice()
    {
        double total = Price * Quantity;
        double discountAmount = total * Discount / 100;
        return total - discountAmount;
    }

    // Method using 'is' operator to safely display product details
    public static void ShowProductDetails(object obj)
    {
        if (obj is Product p)
        {
            Console.WriteLine("\n--- Product Details ---");
            Console.WriteLine("Product ID: " + p.ProductID);
            Console.WriteLine("Product Name: " + p.ProductName);
            Console.WriteLine("Price: ₹" + p.Price);
            Console.WriteLine("Quantity: " + p.Quantity);
            Console.WriteLine("Final Price (after discount): ₹" + p.CalculateFinalPrice());
        }
        else
        {
            Console.WriteLine("Invalid product object.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        // Create product object
        Product item = new Product(id, name, price, qty);

        Console.Write("\nEnter new discount percentage: ");
        double newDiscount = double.Parse(Console.ReadLine());
        Product.UpdateDiscount(newDiscount);

        // Display product details safely
        Product.ShowProductDetails(item);
    }
}
