using System;

class BMICalculator10
{
    static double CalculateBMI(double weight,double heightCm)//calculate BMI
    {
        double heightM=heightCm/100;
        return weight/(heightM*heightM);
    }

    static string GetStatus(double bmi)//get the status of BMI
    {
        if(bmi<18.5)return "Underweight";
        if(bmi<25)return "Normal";
        if(bmi<30)return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        double weight,height,bmi;
        Console.WriteLine("Weight(kg)\tHeight(cm)\tBMI\tStatus");

        for(int i=1;i<=10;i++)//for ten persons
        {
            Console.Write($"Person {i} weight: ");
            weight=Convert.ToDouble(Console.ReadLine());

            Console.Write($"Person {i} height: ");
            height=Convert.ToDouble(Console.ReadLine());

            bmi=CalculateBMI(weight,height);
            Console.WriteLine($"{weight}\t\t{height}\t\t{bmi:F2}\t{GetStatus(bmi)}");
        }
    }
}
