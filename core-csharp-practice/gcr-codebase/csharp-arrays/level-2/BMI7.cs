using System;

class BMI7
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[n][];//2D arr to stre weght,height,BMI
        string[] weightStatus = new string[n]; //sttore  thr weigt

        for (int i = 0; i < n; i++)
            personData[i] = new double[3];

        //take inpt of wehigt and heigt h
        for (int i = 0; i < n; i++)
        {
            double w = -1, h = -1;
            while (w <= 0)
            {
                Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
                w = Convert.ToDouble(Console.ReadLine());
                if (w <= 0) Console.WriteLine("Weight must be positive");
            }
            while (h <= 0)
            {
                Console.Write("Enter height (cm) for person " + (i + 1) + ": ");
                h = Convert.ToDouble(Console.ReadLine());
                if (h <= 0) Console.WriteLine("Height must be positive");
            }

            personData[i][0] = w;//weight
            personData[i][1] = h;//height
            double hM = h / 100.0;
            personData[i][2] = w / (hM * hM);//BMI

            double bmi = personData[i][2];
            if (bmi < 18.5) weightStatus[i] = "Underweight";
            else if (bmi < 24.9) weightStatus[i] = "Normal";
            else if (bmi < 29.9) weightStatus[i] = "Overweight";
            else weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nPerson\tHeight(cm)\tWeight(kg)\tBMI\t\tStatus");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine((i + 1) + "\t" + personData[i][1] + "\t\t" + personData[i][0] + "\t\t" + Math.Round(personData[i][2], 2) + "\t\t" + weightStatus[i]);
        }
    }
}

