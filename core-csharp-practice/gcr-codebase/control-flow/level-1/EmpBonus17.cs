using System;

class EmpBonus17
{
    static void Main()
    {
        double salary,bonus=0;//initailaie varibles
        int years;

        Console.WriteLine("Enter salary:");
        salary=Convert.ToDouble(Console.ReadLine());//take the input

        Console.WriteLine("Enter years:");
        years=Convert.ToInt32(Console.ReadLine()); //take the inpt

        if(years>5)
        {
            bonus=salary*0.05;
        }

        Console.WriteLine("Bonus:"+bonus);
    }
}
