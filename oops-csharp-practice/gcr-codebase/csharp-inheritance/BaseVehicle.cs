using System;

//Base vehicle class
class BaseVehicle
{
    public int MaxSpeed; //Maximum speed
    public string Model; //Vehicle model

    //Constructor
    public BaseVehicle(int maxSpeed,string model)
    {
        MaxSpeed=maxSpeed;
        Model=model;
    }
}

//Interface for refueling behavior
interface IFuelable
{
    //Refuel method
    void Refuel();
}

//Electric vehicle class
class ElectricCar:BaseVehicle
{
    public ElectricCar(int maxSpeed,string model):base(maxSpeed,model){}

    //Charging method for electric vehicles
    public void Charge()
    {
        Console.WriteLine("Electric vehicle is charging");
    }
}

//Petrol vehicle class implementing interface
class PetrolCar:BaseVehicle,IFuelable
{
    public PetrolCar(int maxSpeed,string model):base(maxSpeed,model){}

    //Refuel implementation
    public void Refuel()
    {
        Console.WriteLine("Petrol vehicle is refueling");
    }
}

//Main application
class VehicleApp
{
    static void Main()
    {
        Console.Write("Enter model: ");
        string model=Console.ReadLine()!;

        Console.Write("Enter max speed: ");
        int speed=int.Parse(Console.ReadLine()!);

        Console.Write("Enter vehicle type (electric/petrol): ");
        string type=Console.ReadLine()!.ToLower();

        if(type=="electric")
        {
            ElectricCar ev=new ElectricCar(speed,model);
            ev.Charge();
        }
        else
        {
            PetrolCar pv=new PetrolCar(speed,model);
            pv.Refuel();
        }
    }
}
