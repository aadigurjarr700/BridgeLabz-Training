using System;

class StudentGrades9
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[n, 3];//2D arr for physics, chemistry, maths
        double[] percentage = new double[n]; //percent forstdnt
        string[] grade = new string[n]; //garde fpr student

        //take input from iusr of marks 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int m = -1;
                string sub = (j == 0) ? "Physics" : (j == 1) ? "Chemistry" : "Maths";
                while (m < 0 || m > 100)
                {
                    Console.Write("Enter " + sub + " marks for student " + (i + 1) + ": ");
                    m = Convert.ToInt32(Console.ReadLine());
                    if (m < 0 || m > 100) Console.WriteLine("Invalid marks! Enter 0-100.");
                }
                marks[i, j] = m;
            }

            //calculate  thr percent
            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            double p = percentage[i];
            if (p >= 90) grade[i] = "A+";
            else if (p >= 80) grade[i] = "A";
            else if (p >= 70) grade[i] = "B+";
            else if (p >= 60) grade[i] = "B";
            else if (p >= 50) grade[i] = "C";
            else grade[i] = "F";
        }

        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + "\t");
            for (int j = 0; j < 3; j++) Console.Write(marks[i, j] + "\t\t");
            Console.Write(Math.Round(percentage[i], 2) + "\t\t");
            Console.WriteLine(grade[i]);
        }
    }
}
