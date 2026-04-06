using System;

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// Abstract patient class
abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    // sensitive data (encapsulation)
    private string diagnosis;

    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    // common method
    public void GetPatientDetails()
    {
        Console.WriteLine("----- Patient Details -----");
        Console.WriteLine($"ID   : {patientId}");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age  : {age}");
    }

    protected void SetDiagnosis(string diag)
    {
        diagnosis = diag;
    }
}

// In-Patient class
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;

    // no collections, simple array
    private string[] medicalHistory = new string[5];
    private int recordCount = 0;

    public InPatient(int id, string name, int age, int days)
        : base(id, name, age)
    {
        daysAdmitted = days;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * 2000; // per day charge
    }

    public void AddRecord(string record)
    {
        if (recordCount < medicalHistory.Length)
        {
            medicalHistory[recordCount++] = record;
        }
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History:");
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine("- " + medicalHistory[i]);
        }
    }
}

// Out-Patient class
class OutPatient : Patient, IMedicalRecord
{
    // no collections
    private string[] medicalHistory = new string[5];
    private int recordCount = 0;

    public OutPatient(int id, string name, int age)
        : base(id, name, age) { }

    public override double CalculateBill()
    {
        return 500; // fixed consultation fee
    }

    public void AddRecord(string record)
    {
        if (recordCount < medicalHistory.Length)
        {
            medicalHistory[recordCount++] = record;
        }
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History:");
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine("- " + medicalHistory[i]);
        }
    }
}

// Main class
class HospitalApp
{
    static void Main()
    {
        Console.WriteLine("Select Patient Type:");
        Console.WriteLine("1. In-Patient");
        Console.WriteLine("2. Out-Patient");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Patient patient;

        if (choice == 1)
        {
            Console.Write("Enter Days Admitted: ");
            int days = int.Parse(Console.ReadLine());
            patient = new InPatient(id, name, age, days);
        }
        else
        {
            patient = new OutPatient(id, name, age);
        }

        // polymorphism
        patient.GetPatientDetails();
        Console.WriteLine($"Total Bill: {patient.CalculateBill()}");

        // interface usage
        IMedicalRecord record = (IMedicalRecord)patient;
        record.AddRecord("Initial diagnosis added");
        record.ViewRecords();
    }
}
