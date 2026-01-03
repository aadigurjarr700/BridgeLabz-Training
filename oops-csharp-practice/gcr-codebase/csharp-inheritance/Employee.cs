using System;

// Base class containing common employee details
class Employee
{
    public string Name;     // Employee name
    public int Id;          // Employee ID
    public double Salary;   // Employee salary

    // Constructor to initialize values
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method so subclasses can add extra details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

// Manager class inherits Employee
class Manager : Employee
{
    public int TeamSize; // Number of team members

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    // Adding manager specific information
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

// Developer class inherits Employee
class Developer : Employee
{
    public string ProgrammingLanguage; // Main coding language

    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    // Adding developer specific information
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

// Intern class inherits Employee
class Intern : Employee
{
    public string InternshipDuration; // Duration of internship

    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    // Adding intern specific information
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration: {InternshipDuration}");
    }
}

class Program
{
    static void Main()
    {
        // Asking which employee type user wants
        Console.Write("Enter employee type (manager/developer/intern): ");
        string type = Console.ReadLine().ToLower();

        // Common inputs for all employees
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Employee emp; // Parent reference

        // Creating object based on employee role
        if (type == "manager")
        {
            Console.Write("Enter team size: ");
            int teamSize = int.Parse(Console.ReadLine());
            emp = new Manager(name, id, salary, teamSize);
        }
        else if (type == "developer")
        {
            Console.Write("Enter programming language: ");
            string language = Console.ReadLine();
            emp = new Developer(name, id, salary, language);
        }
        else
        {
            Console.Write("Enter internship duration: ");
            string duration = Console.ReadLine();
            emp = new Intern(name, id, salary, duration);
        }

        Console.WriteLine("\nEmployee Details:");
        // Method call decided at runtime
        emp.DisplayDetails();
    }
}
