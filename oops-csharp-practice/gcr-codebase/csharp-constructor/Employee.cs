using System;

// Parent class
class Employee
{
    public int employeeID;
    protected string department = "";
    private double salary;

    public void SetSalary(double s)
    {
        salary = s;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetDepartment(string dept)
    {
        department = dept;
    }
}

// Child class
class Manager : Employee
{
    public void ShowEmployee()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department); // protected accessed here
        Console.WriteLine("Salary: " + GetSalary());
    }
}

class Program4
{
    static void Main()
    {
        Manager m = new Manager();

        Console.Write("Enter Employee ID: ");
        m.employeeID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Department: ");
        m.SetDepartment(Console.ReadLine() ?? "");

        Console.Write("Enter Salary: ");
        m.SetSalary(Convert.ToDouble(Console.ReadLine()));

        m.ShowEmployee();
    }
}
