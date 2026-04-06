using System;

class Patient
{
    // Static hospital name (same for all patients)
    public static string HospitalName = "City Care Hospital";

    // Static counter for total patients
    private static int totalPatients = 0;

    // Readonly patient ID (cannot be modified)
    public readonly int PatientID;

    // Patient details
    public string Name;
    public int Age;
    public string Ailment;

    // Constructor to assign patient details
    public Patient(int id, string name, int age, string ailment)
    {
        // Using 'this' to avoid confusion
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        // Increase patient count
        totalPatients++;
    }

    // Static method to get total patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("\nTotal Patients Admitted: " + totalPatients);
    }

    // Method using 'is' operator
    public static void ShowPatientDetails(object obj)
    {
        if (obj is Patient p)
        {
            Console.WriteLine("\n--- Patient Details ---");
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Patient ID: " + p.PatientID);
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Age: " + p.Age);
            Console.WriteLine("Ailment: " + p.Ailment);
        }
        else
        {
            Console.WriteLine("Invalid patient object.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Ailment: ");
        string ailment = Console.ReadLine();

        // Create patient object
        Patient patient1 = new Patient(id, name, age, ailment);

        // Display patient details
        Patient.ShowPatientDetails(patient1);

        // Display total number of patients
        Patient.GetTotalPatients();
    }
}
