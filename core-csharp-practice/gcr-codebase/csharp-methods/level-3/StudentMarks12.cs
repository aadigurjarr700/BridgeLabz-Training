using System;

class StudentMarks12
{
    public static int[,] GenerateMarks(int n)//generate random marks for n students in PCM
    {
        int[,] marks = new int[n,3];
        Random rnd = new Random();
        for(int i=0;i<n;i++)
            for(int j=0;j<3;j++)
                marks[i,j] = rnd.Next(35,101); //2-digit marks 35-100
        return marks;
    }

    //calc total, average, percentage
    public static double[,] CalculateStats(int[,] marks)
    {
        int n = marks.GetLength(0);
        double[,] stats = new double[n,3]; //total, average, percentage
        for(int i=0;i<n;i++)
        {
            double total = marks[i,0]+marks[i,1]+marks[i,2];
            double avg = total/3;
            double perc = total/3; // average for 100 marks each
            stats[i,0] = Math.Round(total,2);
            stats[i,1] = Math.Round(avg,2);
            stats[i,2] = Math.Round(perc,2);
        }
        return stats;
    }

    //scorecard
    public static void DisplayScorecard(int[,] marks, double[,] stats)
    {
        Console.WriteLine("Stu\tPhysics\tChem\tMath\tTotal\tAvg\tPercent");
        for(int i=0;i<marks.GetLength(0);i++)
        {
            Console.WriteLine($"{i+1}\t{marks[i,0]}\t{marks[i,1]}\t{marks[i,2]}\t{stats[i,0]}\t{stats[i,1]}\t{stats[i,2]}");
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] marks = GenerateMarks(n);
        double[,] stats = CalculateStats(marks);
        DisplayScorecard(marks, stats);
    }
}
