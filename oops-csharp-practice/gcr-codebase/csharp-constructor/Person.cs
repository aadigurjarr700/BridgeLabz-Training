using System;

class Person
{
    string name;
    int age;

    // Normal constructor
    Person(string n,int a)
    {
        name=n;
        age=a;
    }

    // Copy constructor
    Person(Person p)
    {
        name=p.name;
        age=p.age;
    }

    // Display person data
    void Show()
    {
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
    }

    static void Main()
    {
        // Input from user
        Console.Write("Enter name: ");
        string n=Console.ReadLine();

        Console.Write("Enter age: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Person p1=new Person(n,a);
        Person p2=new Person(p1); // Copying data

        p1.Show();
        p2.Show();
    }
}
