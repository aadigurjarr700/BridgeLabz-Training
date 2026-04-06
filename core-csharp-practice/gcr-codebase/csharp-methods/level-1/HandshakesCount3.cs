using System;

class HandshakesCount3{
    static int GetHandshakes(int n)//method to calculate thr handshakes 
    {
        return (n*(n-1))/2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents=Convert.ToInt32(Console.ReadLine());//take the input from user 

        int handshakes=GetHandshakes(numberOfStudents);//call the method

        Console.WriteLine("Number of possible handshakes: "+handshakes);
    }
}
