using System;

class QuotientRemainder9{
    public static int[] FindRemainderAndQuotient(int number,int divisor)//methdo to find trh quotient and remainder
    {
        int quotient=number/divisor;
        int remainder=number%divisor;
        return new int[]{quotient,remainder};
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number=Convert.ToInt32(Console.ReadLine());///take teh input form usr 
        Console.Write("Enter divisor: ");
        int divisor=Convert.ToInt32(Console.ReadLine());//take teh inptu form usr 

        int[] result=FindRemainderAndQuotient(number,divisor);//call the methods 
        Console.WriteLine("Quotient: "+result[0]);
        Console.WriteLine("Remainder: "+result[1]);
    }
}
