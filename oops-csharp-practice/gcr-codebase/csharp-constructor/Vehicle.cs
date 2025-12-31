using System;

class Vehicle
{
    // Instance variables
    string ownerName;
    string vehicleType;

    // Class variable
    static double registrationFee=5000;

    // Constructor
    Vehicle(string owner,string type)
    {
        ownerName=owner;
        vehicleType=type;
    }

    // Instance method
    void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: "+ownerName);
        Console.WriteLine("Vehicle Type: "+vehicleType);
        Console.WriteLine("Registration Fee: "+registrationFee);
    }

    // Class method
    static void UpdateRegistrationFee(double newFee)
    {
        registrationFee=newFee;
    }

    static void Main()
    {
        Console.Write("Enter owner name: ");
        string owner=Console.ReadLine();

        Console.Write("Enter vehicle type: ");
        string type=Console.ReadLine();

        Console.Write("Enter new registration fee: ");
        double fee=Convert.ToDouble(Console.ReadLine());

        UpdateRegistrationFee(fee);

        Vehicle v=new Vehicle(owner,type);
        v.DisplayVehicleDetails();
    }
}
