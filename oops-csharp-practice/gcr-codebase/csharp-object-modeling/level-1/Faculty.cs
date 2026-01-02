using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;

    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DeptName;

    public Department(string name)
    {
        DeptName = name;
    }
}

// University owns departments (composition)
class University
{
    public string UniversityName;
    public List<Department> Departments = new List<Department>();

    public University(string name)
    {
        UniversityName = name;
    }

    public void AddDepartment(string name)
    {
        Departments.Add(new Department(name));
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter university name: ");
        University uni = new University(Console.ReadLine());

        Console.Write("Enter department name: ");
        uni.AddDepartment(Console.ReadLine());

        Console.Write("Enter faculty name: ");
        Faculty faculty = new Faculty(Console.ReadLine());

        Console.WriteLine("\nUniversity deleted...");
        uni = null; // departments also gone

        Console.WriteLine("Faculty still exists: " + faculty.Name);
    }
}
