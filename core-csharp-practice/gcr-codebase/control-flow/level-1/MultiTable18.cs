using System;

class MultiTable18

{
    static void Main()
    {
        int number;//take the inpt

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());

        for(int i=6;i<=9;i++)
        {
            Console.WriteLine(number+"*"+i+"="+(number*i));
        }
    }
}
