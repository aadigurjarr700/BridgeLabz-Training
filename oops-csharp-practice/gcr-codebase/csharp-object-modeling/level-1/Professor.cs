using System;

class Course
{
    public string CourseName;

    public Course(string name)
    {
        CourseName = name;
    }
}

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Course course)
    {
        Console.WriteLine(Name + " enrolled in " + course.CourseName);
    }
}

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }

    public void AssignCourse(Course course)
    {
        Console.WriteLine(Name + " is teaching " + course.CourseName);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter course name: ");
        Course course = new Course(Console.ReadLine());

        Console.Write("Enter student name: ");
        Student student = new Student(Console.ReadLine());

        Console.Write("Enter professor name: ");
        Professor professor = new Professor(Console.ReadLine());

        student.EnrollCourse(course);
        professor.AssignCourse(course);
    }
}
