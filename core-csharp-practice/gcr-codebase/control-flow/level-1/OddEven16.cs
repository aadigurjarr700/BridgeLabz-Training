using System;

class OddEven16
{
    static void Main()
    {
        int n;//take th inpt

        Console.WriteLine("Enter number:");
        n=Convert.ToInt32(Console.ReadLine());

        if(n>=1)//cehclk natural no.
        {
            for(int i=1;i<=n;i++) 
            {
                if(i%2==0)
                {
                    Console.WriteLine(i+" Even");
                }
                else
                {
                    Console.WriteLine(i+" Odd");
                }
            }
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
