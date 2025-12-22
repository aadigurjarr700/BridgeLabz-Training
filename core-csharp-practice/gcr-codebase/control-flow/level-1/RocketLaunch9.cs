using System;

class RocketLaunch9

{
    static void Main()
    {
        int counter; //take i=the input

        Console.WriteLine("Enter countdown number:");
        counter=Convert.ToInt32(Console.ReadLine()); 

        for(int i=counter;i>=1;i--) 
        {
            Console.WriteLine(i);
        }
    }
}
