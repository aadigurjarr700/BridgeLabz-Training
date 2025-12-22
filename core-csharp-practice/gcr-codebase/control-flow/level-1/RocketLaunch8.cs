using System;

class RocketLaunch8
{
    static void Main()
    {
        int counter; //take inpt

        Console.WriteLine("Enter countdown number:");
        counter=Convert.ToInt32(Console.ReadLine()); 

        while(counter>=1)  
        {
            Console.WriteLine(counter);
            counter--; //dercese the counter
        }
    }
}
