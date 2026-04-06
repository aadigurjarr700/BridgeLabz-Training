using System;

class BMI6
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[n];//stre weights in kg
        double[] height = new double[n];//store heights in cm
        double[] bmi = new double[n];//stre BMI
        string[] status = new string[n];//store thr weight 

        // take inpt form usr of whigth and heigth 
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter weight (kg) for person " + (i+1) + ": ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm) for person " + (i+1) + ": ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            //covrt heigt into meter 
            double hInMeter = height[i] / 100.0;
            bmi[i] = weight[i] / (hInMeter * hInMeter);//clac BMI

            if(bmi[i] < 18.5)
                status[i] = "Underweight";
            else if(bmi[i] < 24.9)
                status[i] = "Normal";
            else if(bmi[i] < 29.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        Console.WriteLine("\nPerson\tHeight(cm)\tWeight(kg)\tBMI\t\tStatus");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine((i+1) + "\t" + height[i] + "\t\t" + weight[i] + "\t\t" + Math.Round(bmi[i],2) + "\t\t" + status[i]);
        }
    }
}

 
