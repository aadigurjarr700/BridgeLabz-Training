using System;

class SimpleInterest11
{
    static void Main()
    {
        double principal, rate, time;
        Console.WriteLine("Enter principal:");
        principal=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter rate:");
        rate=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter time:");
        time=Convert.ToDouble(Console.ReadLine());

        double simpleInterest=(principal*rate*time)/100; //formula

        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time); //output
    }
}
