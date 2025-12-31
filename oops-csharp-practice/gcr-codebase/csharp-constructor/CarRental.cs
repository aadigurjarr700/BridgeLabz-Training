using System;

class CarRental
{
    string customer;
    string car;
    int days;

    // Constructor
    CarRental(string c,string m,int d)
    {
        customer=c;
        car=m;
        days=d;
    }

    // Calculate rental cost
    void TotalCost()
    {
        Console.WriteLine("Total Cost: "+(days*1000));
    }

    static void Main()
    {
        Console.Write("Enter customer name: ");
        string c=Console.ReadLine();

        Console.Write("Enter car model: ");
        string m=Console.ReadLine();

        Console.Write("Enter rental days: ");
        int d=Convert.ToInt32(Console.ReadLine());

        CarRental rent=new CarRental(c,m,d);
        rent.TotalCost();
    }
}
