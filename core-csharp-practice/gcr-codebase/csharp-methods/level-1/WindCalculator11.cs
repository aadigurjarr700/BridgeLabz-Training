using System;

class WindCalculator11
{
    public static double CalculateWindChill(double temperature,double windSpeed)//methdo to calaculate the wind 
    {
        return 35.74+0.6215*temperature+(0.4275*temperature-35.75)*Math.Pow(windSpeed,0.16);
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp=Convert.ToDouble(Console.ReadLine());//take teh ionptu from usr 
        Console.Write("Enter wind speed: ");
        double windSpeed=Convert.ToDouble(Console.ReadLine());//take teh input from usr 

        double windChill=CalculateWindChill(temp,windSpeed);//calla the methdos 

        Console.WriteLine("Wind Chill Temperature: "+windChill);
    }
}
