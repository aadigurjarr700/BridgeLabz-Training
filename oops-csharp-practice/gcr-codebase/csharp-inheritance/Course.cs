using System;

// Base class with general course details
class Course
{
    public string CourseName;   // Name of the course
    public int Duration;        // Course duration in weeks

    // Constructor for course data
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
}

// Second level class for online courses
class OnlineCourse : Course
{
    public string Platform;    // Learning platform name
    public bool IsRecorded;    // Indicates recorded/live course

    // Constructor initializes base and online course data
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
}

// Third level class for paid online courses
class PaidOnlineCourse : OnlineCourse
{
    public double Fee;        // Course fee
    public double Discount;   // Discount amount

    // Constructor initializes all levels of data
    public PaidOnlineCourse(string courseName, int duration, string platform,
                            bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    // Method to calculate final price after discount
    public double CalculateFinalFee()
    {
        return Fee - Discount;
    }
}

class Program
{
    static void Main()
    {
        // Taking basic course details
        Console.Write("Enter course name: ");
        string name = Console.ReadLine();

        Console.Write("Enter course duration (weeks): ");
        int duration = int.Parse(Console.ReadLine());

        // Online course details
        Console.Write("Enter platform name: ");
        string platform = Console.ReadLine();

        Console.Write("Is the course recorded? (true/false): ");
        bool isRecorded = bool.Parse(Console.ReadLine());

        // Payment related details
        Console.Write("Enter course fee: ");
        double fee = double.Parse(Console.ReadLine());

        Console.Write("Enter discount amount: ");
        double discount = double.Parse(Console.ReadLine());

        // Creating paid online course object
        PaidOnlineCourse course = new PaidOnlineCourse(
            name, duration, platform, isRecorded, fee, discount
        );

        // Displaying full course information
        Console.WriteLine("\nCourse Details:");
        Console.WriteLine($"Course Name: {course.CourseName}");
        Console.WriteLine($"Duration: {course.Duration} weeks");
        Console.WriteLine($"Platform: {course.Platform}");
        Console.WriteLine($"Recorded Course: {course.IsRecorded}");
        Console.WriteLine($"Original Fee: {course.Fee}");
        Console.WriteLine($"Discount: {course.Discount}");
        Console.WriteLine($"Final Fee: {course.CalculateFinalFee()}");
    }
}
