using System;

// Parent class that holds common data for all animals
class Animal
{
    public string Name;   // Stores animal name
    public int Age;       // Stores animal age

    // Constructor to initialize animal details
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method so child classes can change the behavior
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Dog class inherits Animal
class Dog : Animal
{
    // Pass values to parent constructor
    public Dog(string name, int age) : base(name, age) { }

    // Dog specific sound
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Cat class inherits Animal
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Cat specific sound
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Bird class inherits Animal
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    // Bird specific sound
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main()
    {
        // Taking animal type from user
        Console.Write("Enter animal type (dog/cat/bird): ");
        string type = Console.ReadLine().ToLower();

        // Taking basic details
        Console.Write("Enter animal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter animal age: ");
        int age = int.Parse(Console.ReadLine());

        // Reference of parent class
        Animal animal;

        // Creating object based on user choice
        if (type == "dog")
            animal = new Dog(name, age);
        else if (type == "cat")
            animal = new Cat(name, age);
        else
            animal = new Bird(name, age);

        // Same method call, different output (polymorphism)
        animal.MakeSound();
    }
}
