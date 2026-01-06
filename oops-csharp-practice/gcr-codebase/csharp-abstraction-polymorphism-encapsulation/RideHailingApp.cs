using System;

// GPS interface
interface IGPS
{
    void UpdateLocation(string location);
    string GetCurrentLocation();
}

// Abstract vehicle class
abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    protected Vehicle(int id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("----- Vehicle Details -----");
        Console.WriteLine($"Vehicle ID: {vehicleId}");
        Console.WriteLine($"Driver    : {driverName}");
    }
}

// Car class
class Car : Vehicle, IGPS
{
    private string location = "Unknown";

    public Car(int id, string driver)
        : base(id, driver, 15) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }

    public string GetCurrentLocation()
    {
        return location;
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    private string location = "Unknown";

    public Bike(int id, string driver)
        : base(id, driver, 10) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }

    public string GetCurrentLocation()
    {
        return location;
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    private string location = "Unknown";

    public Auto(int id, string driver)
        : base(id, driver, 12) { }

    public override double CalculateFare(double distance)
    {
        return (distance * ratePerKm) + 20; // base charge
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }

    public string GetCurrentLocation()
    {
        return location;
    }
}

// Main class
class RideHailingApp
{
    static void Main()
    {
        Console.WriteLine("Select Vehicle:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Bike");
        Console.WriteLine("3. Auto");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehicle ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Driver Name: ");
        string driver = Console.ReadLine();

        Vehicle vehicle;

        if (choice == 1)
            vehicle = new Car(id, driver);
        else if (choice == 2)
            vehicle = new Bike(id, driver);
        else
            vehicle = new Auto(id, driver);

        Console.Write("Enter distance (km): ");
        double distance = double.Parse(Console.ReadLine());

        // Polymorphism
        vehicle.GetVehicleDetails();
        Console.WriteLine($"Fare Amount: {vehicle.CalculateFare(distance)}");
    }
}
