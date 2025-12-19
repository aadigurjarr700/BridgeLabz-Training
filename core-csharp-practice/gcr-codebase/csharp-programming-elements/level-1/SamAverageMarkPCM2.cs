using System;

class SamAverageMarkPCM2
{
    static void Main()
    {
        //Student name and marks
        string studentName="Sam";
        int mathsMark=94;
        int physicsMark=95;
        int chemistryMark=96;
        int totalSubjects=3;
        int maxMarkPerSubject=100;

        //Total marks
        int totalMarks=mathsMark+physicsMark+chemistryMark;

        //Average percentage
        double averagePercentage=(double)totalMarks/totalSubjects;

        //Print result
        Console.WriteLine(studentName+"'s average mark in PCM is "+averagePercentage);
    }
}

