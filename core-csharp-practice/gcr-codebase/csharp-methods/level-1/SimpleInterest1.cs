using System;

class SimpleInterest1{
    static double CalculateSI(double p,double r,double t)
    {
        return (p*r*t)/100; //fromula of simple interest 
    }
    static void Main(){
        Console.Write("Enter Principal: ");
        double principal=Convert.ToDouble(Console.ReadLine()); //take the input from usr 

        Console.Write("Enter Rate of Interest: ");
        double rate=Convert.ToDouble(Console.ReadLine());//take the input from user 

        Console.Write("Enter Time: ");
        double time=Convert.ToDouble(Console.ReadLine());//take the inpuyt from user 

        //calcltaet thr simple interest
        double si=CalculateSI(principal,rate,time);

        Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
