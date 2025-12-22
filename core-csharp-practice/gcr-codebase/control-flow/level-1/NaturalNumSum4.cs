using System;

class NaturalNumSum4
{
    static void Main()
    {
        int number; //take inpt

        Console.WriteLine("Enter a number:");
        number=Convert.ToInt32(Console.ReadLine()); //read inpt

        if(number>=1) //check natural no.
        {
            int sum=number*(number+1)/2; //formula

            Console.WriteLine("The sum of "+number+" natural numbers is "+sum);
        }
        else
        {
            Console.WriteLine("The number "+number+" is not a natural number");
        }
    }
}
