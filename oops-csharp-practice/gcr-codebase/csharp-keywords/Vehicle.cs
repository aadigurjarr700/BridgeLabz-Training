using System;

class Vehicle
{
    // Static registration fee shared by all vehicles
    public static double RegistrationFee = 1500.00;

    // Readonly registration number (cannot be changed)
    public readonly string RegistrationNumber;

    // Vehicle details
    public string OwnerName;
    public string VehicleType;

    // Constructor to initialize vehicle details
    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
    {
        // Using 'this' keyword to avoid name conflict
        this.RegistrationNumber = registrationNumber;
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration fee updated successfully.");
    }

    // Method using 'is' operator to display vehicle details
    public static void ShowVehicleDetails(object obj)
    {
        if (obj is Vehicle v)
        {
            Console.WriteLine("\n--- Vehicle Registration Details ---");
            Console.WriteLine("Registration Number: " + v.RegistrationNumber);
            Console.WriteLine("Owner Name: " + v.OwnerName);
            Console.WriteLine("Vehicle Type: " + v.VehicleType);
            Console.WriteLine("Registration Fee: ₹" + RegistrationFee);
        }
        else
        {
            Console.WriteLine("Invalid vehicle object.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Vehicle Registration Number: ");
        string regNo = Console.ReadLine();

        Console.Write("Enter Owner Name: ");
        string owner = Console.ReadLine();

        Console.Write("Enter Vehicle Type: ");
        string type = Console.ReadLine();

        // Creating Vehicle object
        Vehicle vehicle1 = new Vehicle(regNo, owner, type);

        // Display vehicle details
        Vehicle.ShowVehicleDetails(vehicle1);

        Console.Write("\nDo you want to update registration fee? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter new registration fee: ");
            double newFee = double.Parse(Console.ReadLine());

            Vehicle.UpdateRegistrationFee(newFee);

            // Show updated details
            Vehicle.ShowVehicleDetails(vehicle1);
        }
    }
}
