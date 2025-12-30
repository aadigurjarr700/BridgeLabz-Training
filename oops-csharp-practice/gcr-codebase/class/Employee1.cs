using System;

class Employee
{
    // variables to store employee details
    string name;
    int id;
    double salary;

    // method to take employee data
    public void TakeInput()
    {
        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }

    // method to display employee data
    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    static void Main()
    {
        // creating employee object
        Employee emp = new Employee();

        // taking input from user
        emp.TakeInput();

        // displaying details
        emp.DisplayDetails();
    }
}
