using System;

class Handshakes2{
    static int CalculateHandshakes(int n)//clac thr handeshakes
    {
        return (n*(n-1))/2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students=Convert.ToInt32(Console.ReadLine());//take thr inpt of no of students 

        //claculaet thr  handshakes
        int result=CalculateHandshakes(students);

        Console.WriteLine($"Maximum number of handshakes among {students} students is {result}");
    }
}
