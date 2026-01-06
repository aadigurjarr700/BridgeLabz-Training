using System;

// Insurance related contract
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Abstract Vehicle class
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber => vehicleNumber;
    public string Type => type;
    protected double RentalRate => rentalRate;

    protected Vehicle(string number, string type, double rate)
    {
        vehicleNumber = number;
        this.type = type;
        rentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

// Car implementation
class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, "Car", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return "Car insurance applied";
    }
}

// Bike implementation
class Bike : Vehicle, IInsurable
{
    public Bike(string number, double rate) : base(number, "Bike", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 200;
    }

    public string GetInsuranceDetails()
    {
        return "Bike insurance applied";
    }
}

// Truck implementation
class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate) : base(number, "Truck", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 1.5;
    }

    public double CalculateInsurance()
    {
        return 1000;
    }

    public string GetInsuranceDetails()
    {
        return "Truck insurance applied";
    }
}

class VehicleRental
{
    static void Main()
    {
        Console.Write("How many vehicles? ");
        int count = int.Parse(Console.ReadLine());

        // Using array instead of collections
        Vehicle[] vehicles = new Vehicle[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter type (Car/Bike/Truck): ");
            string type = Console.ReadLine();

            Console.Write("Vehicle Number: ");
            string number = Console.ReadLine();

            Console.Write("Daily Rate: ");
            double rate = double.Parse(Console.ReadLine());

            if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
                vehicles[i] = new Car(number, rate);
            else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                vehicles[i] = new Bike(number, rate);
            else
                vehicles[i] = new Truck(number, rate);
        }

        Console.Write("Enter rental days: ");
        int days = int.Parse(Console.ReadLine());

        // Polymorphism using base class reference
        for (int i = 0; i < vehicles.Length; i++)
        {
            Vehicle v = vehicles[i];
            double rent = v.CalculateRentalCost(days);
            double insurance = ((IInsurable)v).CalculateInsurance();

            Console.WriteLine($"{v.Type} | Rent: {rent} | Insurance: {insurance}");
        }
    }
}
