using System;

class Employee
{
    // Common company name for all employees
    public static string CompanyName = "TechNova Solutions";

    // Keeps track of total employees created
    private static int totalEmployees = 0;

    // Readonly employee ID (cannot be changed later)
    public readonly int Id;

    // Employee details
    public string Name;
    public string Designation;

    // Constructor to initialize employee details
    public Employee(int Id, string Name, string Designation)
    {
        // Using 'this' to clearly assign values
        this.Id = Id;
        this.Name = Name;
        this.Designation = Designation;

        // Increase employee count whenever object is created
        totalEmployees++;
    }

    // Displays total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // Displays employee details safely using 'is' operator
    public static void ShowEmployeeDetails(object obj)
    {
        if (obj is Employee emp)
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee ID: " + emp.Id);
            Console.WriteLine("Name: " + emp.Name);
            Console.WriteLine("Designation: " + emp.Designation);
            Console.WriteLine("Company: " + CompanyName);
        }
        else
        {
            Console.WriteLine("The given object is not an Employee.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Designation: ");
        string designation = Console.ReadLine();

        // Create employee object
        Employee emp1 = new Employee(id, name, designation);

        // Show total employee count
        Employee.DisplayTotalEmployees();

        // Show employee details
        Employee.ShowEmployeeDetails(emp1);
    }
}
