using System;

class ChocolateDistribution10
{
    public static int[] FindRemainderAndQuotient(int number,int divisor)//method to find thr child chclates and remiaing 
    {
        int chocolatesPerChild=number/divisor;
        int remainingChocolates=number%divisor;
        return new int[]{chocolatesPerChild,remainingChocolates};
    }

    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates=Convert.ToInt32(Console.ReadLine());//take the inptu from usr 
        Console.Write("Enter number of children: ");
        int numberOfChildren=Convert.ToInt32(Console.ReadLine());//take the inptu from user 

        int[] result=FindRemainderAndQuotient(numberOfChocolates,numberOfChildren);//call the methdos

        Console.WriteLine("Each child gets: "+result[0]);
        Console.WriteLine("Remaining chocolates: "+result[1]);
    }
}
