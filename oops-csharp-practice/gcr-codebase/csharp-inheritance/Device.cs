using System;

// Base class for all smart devices
class Device
{
    public int DeviceId;     // Unique device identifier
    public string Status;    // Device status (ON/OFF)

    // Constructor to initialize common properties
    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
    }
}

// Thermostat class inherits Device
class Thermostat : Device
{
    public double TemperatureSetting;  // Desired temperature

    // Constructor initializes both device and thermostat data
    public Thermostat(int deviceId, string status, double temperature)
        : base(deviceId, status)
    {
        TemperatureSetting = temperature;
    }

    // Display thermostat-specific details
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}

class Program
{
    static void Main()
    {
        // Taking device information from user
        Console.Write("Enter device ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter device status (ON/OFF): ");
        string status = Console.ReadLine();

        // Taking thermostat-specific input
        Console.Write("Enter temperature setting: ");
        double temp = double.Parse(Console.ReadLine());

        // Creating thermostat object
        Thermostat thermostat = new Thermostat(id, status, temp);

        Console.WriteLine("\nDevice Status:");
        thermostat.DisplayStatus();
    }
}
