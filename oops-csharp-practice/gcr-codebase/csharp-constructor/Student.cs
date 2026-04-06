using System;

// Parent class
class Student
{
    public int rollNumber;           // accessible everywhere
    protected string name = "";      // accessible in child class
    private double cgpa;             // hidden, accessed via methods

    public void SetCGPA(double c)
    {
        cgpa = c;
    }

    public double GetCGPA()
    {
        return cgpa;
    }

    public void SetName(string n)
    {
        name = n;
    }
}

// Child class
class PostgraduateStudent : Student
{
    public void DisplayInfo()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);     // protected accessed here
        Console.WriteLine("CGPA: " + GetCGPA());
    }
}

class Program1
{
    static void Main()
    {
        PostgraduateStudent s = new PostgraduateStudent();

        Console.Write("Enter Roll Number: ");
        s.rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.SetName(Console.ReadLine());

        Console.Write("Enter CGPA: ");
        s.SetCGPA(Convert.ToDouble(Console.ReadLine()));

        s.DisplayInfo();
    }
}
