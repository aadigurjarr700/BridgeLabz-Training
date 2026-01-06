using System;

// Interface for discount behavior
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Abstract base class
abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    protected FoodItem(string name, double price, int quantity)
    {
        this.itemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    // abstract method forces subclasses to define logic
    public abstract double CalculateTotalPrice();

    // common method for all food items
    public void GetItemDetails()
    {
        Console.WriteLine($"Item: {itemName}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Quantity: {quantity}");
    }
}

// Veg food item
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public double ApplyDiscount()
    {
        return 50; // flat veg discount
    }

    public string GetDiscountDetails()
    {
        return "Veg discount applied";
    }
}

// Non-veg food item
class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        // extra charge for non-veg items
        return (price * quantity) + 80;
    }

    public double ApplyDiscount()
    {
        return 30; // smaller discount for non-veg
    }

    public string GetDiscountDetails()
    {
        return "Non-veg discount applied";
    }
}

// Main class
class FoodDeliveryApp
{
    static void Main()
    {
        Console.WriteLine("Choose Food Type:");
        Console.WriteLine("1. Veg");
        Console.WriteLine("2. Non-Veg");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        FoodItem food;

        if (choice == 1)
            food = new VegItem(name, price, qty);
        else
            food = new NonVegItem(name, price, qty);

        // polymorphism in action
        food.GetItemDetails();

        double total = food.CalculateTotalPrice();
        double discount = ((IDiscountable)food).ApplyDiscount();

        Console.WriteLine(((IDiscountable)food).GetDiscountDetails());
        Console.WriteLine($"Final Amount: {total - discount}");
    }
}
