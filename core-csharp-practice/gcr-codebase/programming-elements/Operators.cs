using System;

class Operators
{
    static void Main()
    {
        
        // Arithmetic Operators
        int a = 10, b = 3;
        int add = a + b;    // Addition
        int sub = a - b;    // Subtraction
        int mul = a * b;    // Multiplication
        int div = a / b;    // Division
        int mod = a % b;    // Modulus (remainder)

        //  Relational Operators
        bool eq  = a == b;  // Equal to
        bool neq = a != b;  // Not equal to
        bool gt  = a > b;   // Greater than
        bool lt  = a < b;   // Less than
        bool gte = a >= b;  // Greater than or equal to
        bool lte = a <= b;  // Less than or equal to

        // Logical Operators
        bool andOp = (a > 5) && (b > 1); // Logical AND
        bool orOp  = (a > 20) || (b > 1); // Logical OR
        bool notOp = !(a < b);           // Logical NOT

        // Assignment Operators
        int x = 5;
        x += 2;   // x = x + 2
        x -= 1;   // x = x - 1
        x *= 2;   // x = x * 2
        x /= 2;   // x = x / 2
        x %= 2;   // x = x % 2

        // 5️⃣ Unary Operators
        int y = 10;
        y++;        // Increment
        y--;        // Decrement
        int pos = +y; // Unary plus
        int neg = -y; // Unary minus


        //  Conditional (Ternary) Operator
        string result = (a > b) ? "A is greater" : "B is greater";

        // Null Operator
        string name = null;
        string displayName = name ?? "Guest"; // Null coalescing
        int? length = name?.Length;           // Null conditional

        
        // Type Operators
      
        object obj = "Hello";
        bool checkType = obj is string; // is operator
        string text = obj as string;    // as operator
        Type t = typeof(int);           // typeof operator
        int size = sizeof(int);         // sizeof operator

        Console.WriteLine("All operators demonstrated");
    }
}