using System;

class StudentNode
{
    // Student data
    public int RollNo;
    public string Name;
    public int Age;
    public char Grade;

    // Pointer to next node
    public StudentNode Next;

    // Constructor to assign values
    public StudentNode(int rollNo, string name, int age, char grade)
    {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    // Add student at beginning
    public void AddAtBeginning(int rollNo, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Add student at end
    public void AddAtEnd(int rollNo, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
    }

    // Add student at specific position
    public void AddAtPosition(int position, int rollNo, string name, int age, char grade)
    {
        if (position <= 1)
        {
            AddAtBeginning(rollNo, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        StudentNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Delete student by Roll Number
    public void DeleteByRollNo(int rollNo)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.RollNo == rollNo)
        {
            head = head.Next;
            Console.WriteLine("Student deleted successfully");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != rollNo)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted successfully");
        }
    }

    // Search student by Roll Number
    public void SearchStudent(int rollNo)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                DisplayStudent(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Update student grade
    public void UpdateGrade(int rollNo, char newGrade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Display all students
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available");
            return;
        }

        StudentNode temp = head;
        while (temp != null)
        {
            DisplayStudent(temp);
            temp = temp.Next;
        }
    }

    // Helper method to display single student
    private void DisplayStudent(StudentNode student)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Roll No : " + student.RollNo);
        Console.WriteLine("Name    : " + student.Name);
        Console.WriteLine("Age     : " + student.Age);
        Console.WriteLine("Grade   : " + student.Grade);
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtEnd(1, "Aditya", 21, 'A');
        list.AddAtBeginning(2, "Rohan", 20, 'B');
        list.AddAtPosition(2, 3, "Neha", 22, 'A');

        Console.WriteLine("All Students:");
        list.DisplayAll();

        Console.WriteLine("\nSearching Roll No 3:");
        list.SearchStudent(3);

        Console.WriteLine("\nUpdating Grade:");
        list.UpdateGrade(2, 'A');

        Console.WriteLine("\nDeleting Roll No 1:");
        list.DeleteByRollNo(1);

        Console.WriteLine("\nFinal Student List:");
        list.DisplayAll();
    }
}
