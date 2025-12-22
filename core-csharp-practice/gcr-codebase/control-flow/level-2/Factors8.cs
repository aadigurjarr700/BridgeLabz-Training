using System;

class Factors8
{
    static void Main()
    {
        int number;//take thr inpt

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors are:");

        //find the factrs
        for(int i=1;i<number;i++)
        {
            if(number%i==0) //check the divsblity
            {
                Console.WriteLine(i);
            }
        }
    }
}
