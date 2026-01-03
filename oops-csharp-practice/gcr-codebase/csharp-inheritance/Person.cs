using System;

// Base class representing a common person
class Person
{
    public string Name; // Person name
    public int Age;     // Person age

    // Initializes personal details
    public Person(string name,int age)
    {
        Name=name;
        Age=age;
    }
}

// Teacher class inherits Person
class Teacher:Person
{
    public string Subject; // Subject handled by teacher

    public Teacher(string name,int age,string subject)
        :base(name,age)
    {
        Subject=subject;
    }

    // Displays teacher role
    public void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
    }
}

// Student class inherits Person
class Student:Person
{
    public string Grade; // Student grade

    public Student(string name,int age,string grade)
        :base(name,age)
    {
        Grade=grade;
    }

    // Displays student role
    public void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }
}

// Staff class inherits Person
class Staff:Person
{
    public string Department; // Staff department

    public Staff(string name,int age,string department)
        :base(name,age)
    {
        Department=department;
    }

    // Displays staff role
    public void DisplayRole()
    {
        Console.WriteLine("Role: Staff Member");
    }
}

class Program
{
    static void Main()
    {
        // Taking basic person details
        Console.Write("Enter name: ");
        string name=Console.ReadLine();

        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());

        Console.Write("Choose role (teacher/student/staff): ");
        string role=Console.ReadLine().ToLower();

        // Creating object based on role
        if(role=="teacher")
        {
            Console.Write("Enter subject: ");
            string subject=Console.ReadLine();
            Teacher t=new Teacher(name,age,subject);
            t.DisplayRole();
        }
        else if(role=="student")
        {
            Console.Write("Enter grade: ");
            string grade=Console.ReadLine();
            Student s=new Student(name,age,grade);
            s.DisplayRole();
        }
        else
        {
            Console.Write("Enter department: ");
            string dept=Console.ReadLine();
            Staff st=new Staff(name,age,dept);
            st.DisplayRole();
        }
    }
}
