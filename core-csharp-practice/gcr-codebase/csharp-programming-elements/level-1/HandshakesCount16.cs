using System;

class HandshakesCount16
{
    static void Main()
    {
        int numberOfStudents;                    //total students

        Console.WriteLine("Enter number of students:");
        numberOfStudents=Convert.ToInt32(Console.ReadLine()); //input

        int handshakes=(numberOfStudents*(numberOfStudents-1))/2; //formula

        Console.WriteLine("The maximum number of handshakes is "+handshakes); //output
    }
}
