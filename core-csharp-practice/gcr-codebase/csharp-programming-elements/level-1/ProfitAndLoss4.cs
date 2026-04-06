using System;

class ProfitAndLoss4
{
    static void Main()
    {
        //Cost price and selling price
        double costPrice=129;
        double sellingPrice=191;

        //Calculate profit
        double profit=sellingPrice-costPrice;

        //Calculate profit percentage
        double profitPercentage=(profit/costPrice)*100;

        //Display result using single print statement
        Console.WriteLine(
            "The Cost Price is INR "+costPrice+" and Selling Price is INR "+sellingPrice+
            "\nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage
        );
    }
}
