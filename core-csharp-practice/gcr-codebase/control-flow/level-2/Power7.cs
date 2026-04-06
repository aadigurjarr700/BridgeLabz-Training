using System;

class PowerOfNumber
{
    static void Main()
    {
        int number,power; //intialize thr variables 
        int result=1;

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter power:");
        power=Convert.ToInt32(Console.ReadLine());

        //calclate the power
        for(int i=1;i<=power;i++)
        {
            result=result*number;
        }

        Console.WriteLine("Result is "+result);
    }
}
