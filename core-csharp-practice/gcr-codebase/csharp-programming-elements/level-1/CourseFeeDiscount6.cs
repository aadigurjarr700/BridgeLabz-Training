using System;

class CourseFeeDiscount6
{
    static void Main()
    {
        double fee=125000;              //course fee
        double discountPercent=10;      //discount percent

        double discount=fee*discountPercent/100; //discount amount
        double finalFee=fee-discount;   //final fee

        Console.WriteLine("The discount amount is INR "+discount+
                          " and final discounted fee is INR "+finalFee); //output
    }
}
