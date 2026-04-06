using System;

class HotelBooking
{
    string guest;
    string room;
    int nights;

    // Default constructor
    HotelBooking()
    {
        guest="Guest";
        room="Standard";
        nights=1;
    }

    // Parameterized constructor
    HotelBooking(string g,string r,int n)
    {
        guest=g;
        room=r;
        nights=n;
    }

    // Copy constructor
    HotelBooking(HotelBooking h)
    {
        guest=h.guest;
        room=h.room;
        nights=h.nights;
    }

    void Show()
    {
        Console.WriteLine("Guest: "+guest);
        Console.WriteLine("Room: "+room);
        Console.WriteLine("Nights: "+nights);
    }

    static void Main()
    {
        Console.Write("Enter guest name: ");
        string g=Console.ReadLine();

        Console.Write("Enter room type: ");
        string r=Console.ReadLine();

        Console.Write("Enter number of nights: ");
        int n=Convert.ToInt32(Console.ReadLine());

        HotelBooking b1=new HotelBooking(g,r,n);
        HotelBooking b2=new HotelBooking(b1); // Copy booking

        b1.Show();
        b2.Show();
    }
}
