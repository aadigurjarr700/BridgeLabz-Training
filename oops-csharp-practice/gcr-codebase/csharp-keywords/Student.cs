using System;

class Student
{
    // Static variable shared by all students
    public static string UniversityName = "Open University";

    // Static counter to track total students
    private static int totalStudents = 0;

    // Readonly roll number (cannot be modified)
    public readonly int RollNumber;

    // Student details
    public string Name;
    public string Grade;

    // Constructor to initialize student data
    public Student(int RollNumber, string Name, string Grade)
    {
        // Using 'this' keyword to avoid confusion
        this.RollNumber = RollNumber;
        this.Name = Name;
        this.Grade = Grade;

        totalStudents++;
    }

    // Static method to show total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // Method to update grade safely
    public void UpdateGrade(string newGrade)
    {
        this.Grade = newGrade;
        Console.WriteLine("Grade updated successfully.");
    }

    // Method using 'is' operator to display details
    public static void ShowStudentDetails(object obj)
    {
        if (obj is Student s)
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Roll Number: " + s.RollNumber);
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Grade: " + s.Grade);
        }
        else
        {
            Console.WriteLine("Invalid student object.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();

        // Creating student object
        Student student1 = new Student(roll, name, grade);

        // Show student information
        Student.ShowStudentDetails(student1);

        Console.Write("\nEnter new grade to update: ");
        string newGrade = Console.ReadLine();
        student1.UpdateGrade(newGrade);

        // Show updated details
        Student.ShowStudentDetails(student1);

        // Display total students
        Student.DisplayTotalStudents();
    }
}
