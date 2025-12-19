using System;

class FindAgeOfHarry1
{
    static void Main()
    {
        //Declaring the  variables
        string name="Harry";
        int birthYear=2000;
        int currentYear=2024;

        //Calculate age of harry 
        int age=currentYear-birthYear;

        //Displaying the age of harry
        Console.WriteLine(name+"'s age in "+currentYear+" is "+age);
    }
}
