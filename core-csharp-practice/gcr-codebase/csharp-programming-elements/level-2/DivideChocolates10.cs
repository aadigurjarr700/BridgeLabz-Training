using System;

class DivideChocolates10
{
    static void Main()
    {
        int numberOfChocolates, numberOfChildren;
        Console.WriteLine("Enter number of chocolates:");
        numberOfChocolates=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of children:");
        numberOfChildren=Convert.ToInt32(Console.ReadLine());

        int chocolatesPerChild=numberOfChocolates/numberOfChildren; //division
        int remainingChocolates=numberOfChocolates%numberOfChildren; //modulus

        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+" and the number of remaining chocolates is "+remainingChocolates); //output
    }
}
