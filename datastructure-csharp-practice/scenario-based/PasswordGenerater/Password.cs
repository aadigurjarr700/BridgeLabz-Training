using System;

namespace PasswordCracker
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Password Cracker Simulator ---");
                Console.WriteLine("1. Generate all strings of length n");
                Console.WriteLine("2. Crack password (stop when matched)");
                Console.WriteLine("3. Time & Space Complexity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter length: ");
                        int n = int.Parse(Console.ReadLine());
                        IPasswordOperation gen = new PasswordGenerator(n);
                        gen.Execute();
                        break;

                    case 2:
                        Console.Write("Enter password: ");
                        string pwd = Console.ReadLine();
                        IPasswordOperation matcher = new PasswordMatcher(pwd);
                        matcher.Execute();
                        break;

                    case 3:
                        ComplexityUtil.Show();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
