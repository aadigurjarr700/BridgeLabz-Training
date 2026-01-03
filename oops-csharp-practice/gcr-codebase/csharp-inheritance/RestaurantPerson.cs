using System;

//Base class representing a person in restaurant
class RestaurantPerson
{
    public string Name; //Person name
    public int Id;      //Person ID

    //Constructor to initialize person details
    public RestaurantPerson(string name,int id)
    {
        Name=name;
        Id=id;
    }
}

//Interface defining worker behavior
interface IRestaurantWorker
{
    //Method that every worker must implement
    void PerformDuties();
}

//Chef class inherits RestaurantPerson and implements interface
class RestaurantChef:RestaurantPerson,IRestaurantWorker
{
    public RestaurantChef(string name,int id):base(name,id){}

    //Chef specific implementation
    public void PerformDuties()
    {
        Console.WriteLine("Chef is cooking food");
    }
}

//Waiter class inherits RestaurantPerson and implements interface
class RestaurantWaiter:RestaurantPerson,IRestaurantWorker
{
    public RestaurantWaiter(string name,int id):base(name,id){}

    //Waiter specific implementation
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving customers");
    }
}

class RestaurantApp
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name=Console.ReadLine()!;

        Console.Write("Enter id: ");
        int id=int.Parse(Console.ReadLine()!);

        Console.Write("Enter role (chef/waiter): ");
        string role=Console.ReadLine()!.ToLower();

        //Polymorphism using interface reference
        IRestaurantWorker worker;

        if(role=="chef")
            worker=new RestaurantChef(name,id);
        else
            worker=new RestaurantWaiter(name,id);

        worker.PerformDuties();
    }
}
