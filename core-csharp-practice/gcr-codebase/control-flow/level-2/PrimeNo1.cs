using System;

class PrimeNo1
{
    static void Main()
    {
        int number;//take inpt
        bool isPrime=true;

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());

        if(number<=1)//check thr prime 
        {
            isPrime=false;
        }
        else
        {
            for(int i=2;i<number;i++)
            {
                if(number%i==0)
                {
                    isPrime=false;
                    break;
                }
            }
        }

        if(isPrime)// rseult 
        {
            Console.WriteLine(number+" is a Prime Number");
        }
        else
        {
            Console.WriteLine(number+" is Not a Prime Number");
        }
    }
}
