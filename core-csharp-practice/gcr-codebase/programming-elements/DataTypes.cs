using System;

class DataTypes
{
    static void Main()
    {
        
        //Integer (int)
        int intNum = 100;
        Console.WriteLine("Integer example: " + intNum);

        //Float
        float floatNum = 12.5f;
        Console.WriteLine("Float example: " + floatNum);

        //Double
        double doubleNum = 123.456;
        Console.WriteLine("Double example: " + doubleNum);

        //Char
        char character = 'A';
        Console.WriteLine("Char example: " + character);

        //Boolean
        bool isTrue = true;
        Console.WriteLine("Boolean example: " + isTrue);

        //String
        string name = "Abhishek";
        Console.WriteLine("String example: " + name);

        Console.WriteLine();
        Console.WriteLine("===== Type Casting Examples =====");

        //Implicit Casting (smaller to larger type)
        int smallInt = 50;
        double largeDouble = smallInt;    // Implicit casting
        Console.WriteLine("Implicit Casting (int to double): " + largeDouble);

        //Explicit Casting (larger to smaller type)
        double bigDouble = 123.45;
        int intFromDouble = (int)bigDouble;  // Explicit casting
        Console.WriteLine("Explicit Casting (double to int): " + intFromDouble);

        //Using Convert class
        string strNumber = "200";
        int numFromString = Convert.ToInt32(strNumber);
        Console.WriteLine("Using Convert.ToInt32: " + numFromString);

        double doubleFromString = Convert.ToDouble("123.45");
        Console.WriteLine("Using Convert.ToDouble: " + doubleFromString);

        //String to char array
        string sample = "Hello";
        char firstChar = sample[0];  // Access first character
        Console.WriteLine("First character of \"" + sample + "\": " + firstChar);


        //Numeric to String
        int num = 999;
        string strFromNum = num.ToString();
        Console.WriteLine("Integer to String: " + strFromNum);

        //Char to Int (ASCII value)
        char ch = 'B';
        int asciiValue = ch;  // Implicitly converts char to int (ASCII)
        Console.WriteLine("ASCII value of '" + ch + "': " + asciiValue);

        Console.WriteLine();
        Console.WriteLine("All data type examples and type casting demonstrated!");
    }
}