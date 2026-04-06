using System;

class HeightConversion10
{
    static void Main()
    {
        double heightCm;                       //height in cm
        Console.WriteLine("Enter height in cm:");
        heightCm=Convert.ToDouble(Console.ReadLine()); //user input

        double totalInches=heightCm/2.54;      //cm to inches
        int feet=(int)(totalInches/12);        //inches to feet
        double inches=totalInches%12;          //remaining inches

        Console.WriteLine("Your Height in cm is "+heightCm+" while in feet is "+feet+" and inches is "+inches); //output
    }
}
