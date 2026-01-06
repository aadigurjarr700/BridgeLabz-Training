using System;

// Interface defining department related behavior
interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

// Abstract base class for Employee
abstract class Employee
{
    // encapsulated fields
    private int employeeId;
    private string name;
    private double baseSalary;

    // properties with validation
    public int EmployeeId
    {
        get => employeeId;
        protected set
        {
            if (value <= 0)
                throw new ArgumentException("Employee ID must be positive");
            employeeId = value;
        }
    }

    public string Name
    {
        get => name;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public double BaseSalary
    {
        get => baseSalary;
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative");
            baseSalary = value;
        }
    }

    protected Employee(int id, string name, double baseSalary)
    {
        EmployeeId = id;
        Name = name;
        BaseSalary = baseSalary;
    }

    // abstract method
    public abstract double CalculateSalary();

    // common concrete method
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary()}");
    }
}

// Full-time employee
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }

    public override double CalculateSalary()
    {
        return BaseSalary; // fixed salary
    }

    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }
}

// Part-time employee
class PartTimeEmployee : Employee, IDepartment
{
    private int workHours;
    private string department;
    private const double hourlyRate = 500;

    public PartTimeEmployee(int id, string name, int hours)
        : base(id, name, 0)
    {
        workHours = hours;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }

    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return $"Department: {department}";
    }
}

// Main class
class EmployeeManagement
{
    static void Main()
    {
        // array instead of collection
        Employee[] employees = new Employee[2];

        Employee e1 = new FullTimeEmployee(101, "Aditya", 60000);
        Employee e2 = new PartTimeEmployee(102, "Rahul", 40);

        ((IDepartment)e1).AssignDepartment("IT");
        ((IDepartment)e2).AssignDepartment("Support");

        employees[0] = e1;
        employees[1] = e2;

        // polymorphism in action
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].DisplayDetails();
        }
    }
}
