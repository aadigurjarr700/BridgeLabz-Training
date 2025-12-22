using System;

class BMIcalculator4
{
    static void Main()
    {
        double weight,heightCm,heightM,bmi;//intitlaize the vaibles 

        Console.WriteLine("Enter weight in kg:");
        weight=Convert.ToDouble(Console.ReadLine());// take inot of weigth 

        Console.WriteLine("Enter height in cm:");
        heightCm=Convert.ToDouble(Console.ReadLine());//take the input of hieght 

        heightM=heightCm/100; // centimtr to mtr
        bmi=weight/(heightM*heightM);//formalue

        Console.WriteLine("BMI is "+bmi);

        if(bmi<18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if(bmi<25)
        {
            Console.WriteLine("Normal weight");
        }
        else if(bmi<30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}
