using System;

// Base class for all vehicles
class Vehicle
{
    public int MaxSpeed;     // Maximum speed of vehicle
    public string FuelType;  // Type of fuel used

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method for displaying details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}");
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

// Car class inherits Vehicle
class Car : Vehicle
{
    public int SeatCapacity; // Number of seats

    public Car(int speed, string fuel, int seats)
        : base(speed, fuel)
    {
        SeatCapacity = seats;
    }

    // Adding car specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}

// Truck class inherits Vehicle
class Truck : Vehicle
{
    public int PayloadCapacity; // Load capacity in kg

    public Truck(int speed, string fuel, int payload)
        : base(speed, fuel)
    {
        PayloadCapacity = payload;
    }

    // Adding truck specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
    }
}

// Motorcycle class inherits Vehicle
class Motorcycle : Vehicle
{
    public bool HasSidecar; // Indicates sidecar presence

    public Motorcycle(int speed, string fuel, bool sidecar)
        : base(speed, fuel)
    {
        HasSidecar = sidecar;
    }

    // Adding motorcycle specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}

class Program
{
    static void Main()
    {
        // Array of parent type holding different child objects
        Vehicle[] vehicles = new Vehicle[3];

        // Storing different vehicle objects
        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 10000);
        vehicles[2] = new Motorcycle(150, "Petrol", false);

        Console.WriteLine("Vehicle Details:\n");

        // Same method call behaves differently for each object
        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine("-------------------");
        }
    }
}
