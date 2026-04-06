using System;

class Course
{
    // Instance variables
    string courseName;
    int duration;
    double fee;

    // Class variable (common for all)
    static string instituteName="Skill Academy";

    // Constructor
    Course(string name,int d,double f)
    {
        courseName=name;
        duration=d;
        fee=f;
    }

    // Instance method
    void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: "+instituteName);
        Console.WriteLine("Course Name: "+courseName);
        Console.WriteLine("Duration: "+duration+" months");
        Console.WriteLine("Fee: "+fee);
    }

    // Class method
    static void UpdateInstituteName(string newName)
    {
        instituteName=newName;
    }

    static void Main()
    {
        Console.Write("Enter course name: ");
        string name=Console.ReadLine();

        Console.Write("Enter duration (months): ");
        int d=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fee: ");
        double f=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter institute name: ");
        string ins=Console.ReadLine();

        UpdateInstituteName(ins);

        Course c=new Course(name,d,f);
        c.DisplayCourseDetails();
    }
}
