using System;
using System.Collections.Generic;

class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DepartmentName;
    public List<Employee> Employees = new List<Employee>();

    public Department(string name)
    {
        DepartmentName = name;
    }

    public void AddEmployee(string empName)
    {
        Employees.Add(new Employee(empName));
    }
}

class Company
{
    public string CompanyName;
    public List<Department> Departments = new List<Department>();

    public Company(string name)
    {
        CompanyName = name;
    }

    public void AddDepartment(Department dept)
    {
        Departments.Add(dept);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Company company = new Company(companyName);

        Console.Write("How many departments? ");
        int deptCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= deptCount; i++)
        {
            Console.Write("\nEnter department name: ");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptName);

            Console.Write("Number of employees in this department: ");
            int empCount = int.Parse(Console.ReadLine());

            for (int j = 1; j <= empCount; j++)
            {
                Console.Write("Enter employee name: ");
                string empName = Console.ReadLine();
                dept.AddEmployee(empName);
            }

            company.AddDepartment(dept);
        }

        Console.WriteLine("\nCompany setup completed successfully.");
    }
}
