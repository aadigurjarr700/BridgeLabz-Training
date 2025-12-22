using System;

class DivByFive1
{
    static void Main()
    {
        int number; 

        Console.WriteLine("Enter a number:");
        number=Convert.ToInt32(Console.ReadLine()); //take input form user

        bool isDivisible=number%5==0; //check the no.is divisible by 5 or not

        Console.WriteLine("Is the number "+number+" divisible by 5? "+isDivisible);
    }
}
