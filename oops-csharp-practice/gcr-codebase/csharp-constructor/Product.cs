using System;

class Product
{
    // Instance variables (unique for each product)
    string productName;
    double price;

    // Class variable (shared by all products)
    static int totalProducts = 0;

    // Constructor
    Product(string name,double p)
    {
        productName=name;
        price=p;
        totalProducts++; // increase count
    }

    // Instance method
    void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: "+productName);
        Console.WriteLine("Price: "+price);
    }

    // Class method
    static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: "+totalProducts);
    }

    static void Main()
    {
        Console.Write("Enter product name: ");
        string name=Console.ReadLine();

        Console.Write("Enter price: ");
        double price=Convert.ToDouble(Console.ReadLine());

        Product p1=new Product(name,price);
        p1.DisplayProductDetails();

        DisplayTotalProducts();
    }
}
