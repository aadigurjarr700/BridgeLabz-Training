using System;

class DiscountWithInput9
{
    static void Main()
    {
        double fee;                            //student fee
        double discountPercent;                //discount percent

        Console.WriteLine("Enter fee:");
        fee=Convert.ToDouble(Console.ReadLine()); //input fee

        Console.WriteLine("Enter discount percent:");
        discountPercent=Convert.ToDouble(Console.ReadLine()); //input discount

        double discount=fee*discountPercent/100; //discount amount
        double finalFee=fee-discount;           //final fee

        Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+finalFee); //output
    }
}
