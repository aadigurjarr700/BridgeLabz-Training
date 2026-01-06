using System;

// Interface for tax calculation
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract product class
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId
    {
        get => productId;
        protected set
        {
            if (value <= 0)
                throw new ArgumentException("Invalid Product ID");
            productId = value;
        }
    }

    public string Name
    {
        get => name;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Product name cannot be empty");
            name = value;
        }
    }

    public double Price
    {
        get => price;
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative");
            price = value;
        }
    }

    protected Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    // abstract discount method
    public abstract double CalculateDiscount();
}

// Electronics product
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 18%";
    }
}

// Clothing product
class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 5%";
    }
}

// Grocery product
class Groceries : Product
{
    public Groceries(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

// Main class
class EcommercePlatform
{
    static void Main()
    {
        // array instead of collection
        Product[] products = new Product[3];

        products[0] = new Electronics(1, "Laptop", 60000);
        products[1] = new Clothing(2, "Jacket", 3000);
        products[2] = new Groceries(3, "Rice Bag", 1200);

        // Polymorphic processing
        for (int i = 0; i < products.Length; i++)
        {
            Product product = products[i];
            double tax = 0;

            if (product is ITaxable)
            {
                tax = ((ITaxable)product).CalculateTax();
            }

            double finalPrice = product.Price + tax - product.CalculateDiscount();

            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Final Price: {finalPrice}");
            Console.WriteLine("-------------------------");
        }
    }
}
