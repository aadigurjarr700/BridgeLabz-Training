using System;

class VotingEligibility5
{
    static void Main()
    {
        int age; //take age inpt

        Console.WriteLine("Enter age:");
        age=Convert.ToInt32(Console.ReadLine()); //read age

        if(age>=18) //check voting eligibilty
        {
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is "+age+" and cannot vote.");
        }
    }
}
