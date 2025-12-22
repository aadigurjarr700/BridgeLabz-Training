using System; //for console

//Parent class
class Animal
{
    public int a=10;//public
    private int b=20;//private
    protected int c=30;//protected
    internal int d=40;//internal
    protected internal int e=50;//protected internal
    private protected int f=60;//private protected

    public void Show()
    {
        Console.WriteLine("b: "+b);//private works here
    }
}

//Child class
class Dog:Animal
{
    public void Display()
    {
        Console.WriteLine("a: "+a); //public
        Console.WriteLine("c: "+c); //protected
        Console.WriteLine("d: "+d); //internal
        Console.WriteLine("e: "+e); //protected internal

        //b not accessible
        //f only works in same project child
    }
}

//Main class
class TestAccessModifiers
{
    static void Main()
    {
        Animal obj=new Animal();

        Console.WriteLine("a: "+obj.a); //public
        Console.WriteLine("d: "+obj.d); //internal
        Console.WriteLine("e: "+obj.e); //protected internal

        //b and c not accessible here

        obj.Show(); //call parent method

        Dog dog=new Dog();
        dog.Display(); //call child method
    }
}
