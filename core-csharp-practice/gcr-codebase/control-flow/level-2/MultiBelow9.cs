using System;

class MultiBelow9
{
    static void Main()
    {
        int number;///take rthe inpot

        Console.WriteLine("Enter number:");
        number=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiples below 100:");
        for(int i=100;i>=1;i--)
        {
            if(i%number==0) //cchekc the multipls
            {
                Console.WriteLine(i);
            }
        }
    }
}
