using System;

class DividePens5
{
    static void Main()
    {
        int totalPens=14;          //total pens
        int totalStudents=3;       //number of students

        int pensPerStudent=totalPens/totalStudents; //division
        int remainingPens=totalPens%totalStudents;  //modulus

        Console.WriteLine("The Pen Per Student is "+pensPerStudent+
                          " and the remaining pen not distributed is "+remainingPens); //output
    }
}
