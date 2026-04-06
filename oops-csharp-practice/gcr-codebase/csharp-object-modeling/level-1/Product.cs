using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public int Price;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Order
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowBill()
    {
        int total = 0;
        Console.WriteLine("\nOrder Summary:");
        foreach (Product p in Products)
        {
            Console.WriteLine(p.Name + " - ₹" + p.Price);
            total += p.Price;
        }
        Console.WriteLine("Total Amount: ₹" + total);
    }
}

class Customer
{
    public string Name;

    public Customer(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter customer name: ");
        Customer customer = new Customer(Console.ReadLine());

        Order order = new Order();

        Console.Write("Enter product name: ");
        string pname = Console.ReadLine();

        Console.Write("Enter product price: ");
        int price = int.Parse(Console.ReadLine());

        order.AddProduct(new Product(pname, price));
        order.ShowBill();
    }
}
