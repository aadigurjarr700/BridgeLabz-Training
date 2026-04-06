using System;

// Node class for Circular Linked List
class TaskNode
{
    // Task details
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;

    // Pointer to next node
    public TaskNode Next;

    // Constructor
    public TaskNode(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

// Circular Linked List class
class TaskCircularLinkedList
{
    private TaskNode head;
    private TaskNode current;

    // Add task at beginning
    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        newNode.Next = head;
        temp.Next = newNode;
        head = newNode;
    }

    // Add task at end
    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Add task at specific position
    public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
    {
        if (position <= 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode temp = head;
        for (int i = 1; i < position - 1 && temp.Next != head; i++)
        {
            temp = temp.Next;
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Remove task by Task ID
    public void RemoveByTaskId(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty");
            return;
        }

        TaskNode curr = head;
        TaskNode prev = null;

        do
        {
            if (curr.TaskId == taskId)
            {
                if (curr == head)
                {
                    TaskNode temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }

                    if (head.Next == head)
                    {
                        head = null;
                        current = null;
                    }
                    else
                    {
                        head = head.Next;
                        temp.Next = head;
                    }
                }
                else
                {
                    prev.Next = curr.Next;
                }

                Console.WriteLine("Task removed successfully");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);

        Console.WriteLine("Task not found");
    }

    // View current task and move to next
    public void ViewCurrentTask()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        DisplayTask(current);
        current = current.Next;
    }

    // Display all tasks
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to display");
            return;
        }

        TaskNode temp = head;
        do
        {
            DisplayTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search task by priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                DisplayTask(temp);
                found = true;
            }
            temp = temp.Next;

        } while (temp != head);

        if (!found)
            Console.WriteLine("No tasks found with this priority");
    }

    // Helper method to display task
    private void DisplayTask(TaskNode task)
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Task ID   : " + task.TaskId);
        Console.WriteLine("Task Name : " + task.TaskName);
        Console.WriteLine("Priority  : " + task.Priority);
        Console.WriteLine("Due Date  : " + task.DueDate);
    }
}

// Main class
class Program
{
    static void Main()
    {
        TaskCircularLinkedList scheduler = new TaskCircularLinkedList();

        scheduler.AddAtEnd(1, "Design Module", 1, "10-01-2026");
        scheduler.AddAtEnd(2, "Write Code", 2, "15-01-2026");
        scheduler.AddAtBeginning(3, "Requirement Analysis", 1, "05-01-2026");

        Console.WriteLine("All Tasks:");
        scheduler.DisplayAllTasks();

        Console.WriteLine("\nCurrent Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nNext Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nSearch by Priority (1):");
        scheduler.SearchByPriority(1);

        Console.WriteLine("\nRemove Task ID 2:");
        scheduler.RemoveByTaskId(2);

        Console.WriteLine("\nFinal Task List:");
        scheduler.DisplayAllTasks();
    }
}
