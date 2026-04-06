using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        CourseName = name;
    }

    // show all students in this course
    public void ShowStudents()
    {
        Console.WriteLine("\nStudents enrolled in " + CourseName + ":");
        foreach (Student s in Students)
        {
            Console.WriteLine("- " + s.Name);
        }
    }
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    // enroll student into course
    public void Enroll(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }

    // show student courses
    public void ShowCourses()
    {
        Console.WriteLine("\nCourses of " + Name + ":");
        foreach (Course c in Courses)
        {
            Console.WriteLine("- " + c.CourseName);
        }
    }
}

// School aggregates students
class School
{
    public string SchoolName;
    public List<Student> Students = new List<Student>();

    public School(string name)
    {
        SchoolName = name;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter school name: ");
        School school = new School(Console.ReadLine());

        Console.Write("Enter student name: ");
        Student student = new Student(Console.ReadLine());

        Console.Write("Enter course name: ");
        Course course = new Course(Console.ReadLine());

        student.Enroll(course);

        student.ShowCourses();
        course.ShowStudents();
    }
}
