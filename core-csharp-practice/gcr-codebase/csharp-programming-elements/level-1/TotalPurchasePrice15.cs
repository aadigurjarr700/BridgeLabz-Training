using System;

class TotalPurchasePrice15
{
    static void Main()
    {
        double unitPrice;                        //price per item
        int quantity;                            //number of items

        Console.WriteLine("Enter unit price:");
        unitPrice=Convert.ToDouble(Console.ReadLine()); //input price

        Console.WriteLine("Enter quantity:");
        quantity=Convert.ToInt32(Console.ReadLine());   //input quantity

        double totalPrice=unitPrice*quantity;    //total cost

        Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity "+quantity+" and unit price is INR "+unitPrice); //output
    }
}
