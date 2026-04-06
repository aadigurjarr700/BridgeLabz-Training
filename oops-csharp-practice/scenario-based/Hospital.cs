using System;

#region IPayable.cs

public interface IPayable
{
    decimal Amount { get; }
    bool IsPaid { get; }
    void ProcessPayment();
    void PrintReceipt();
}

#endregion

#region Doctor.cs

public sealed class Doctor
{
    private string name;
    private string specialization;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be Empty.");
            }
            name = value;
        }
    }

    public string Specialization
    {
        get => specialization;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Specialization cannot be Empty.");
            }
            specialization = value;
        }
    }

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }
}

#endregion

#region Patient.cs

public abstract class Patient
{
    private string name;
    private int age;
    private readonly Doctor assignedDoctor;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name cannot be Empty");
            }
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0 || value > 120)
            {
                throw new ArgumentException("Age must be between 1 and 120.");
            }
            age = value;
        }
    }

    public Doctor AssignedDoctor => assignedDoctor;

    protected Patient(string name, int age, Doctor doctor)
    {
        if (doctor == null)
        {
            throw new ArgumentNullException(nameof(doctor));
        }
        Name = name;
        Age = age;
        assignedDoctor = doctor;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("=== Patient Information ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Doctor: {AssignedDoctor.Name} ({AssignedDoctor.Specialization})");
    }
}

#endregion

#region InPatient.cs

public sealed class InPatient : Patient
{
    private int roomNumber;
    private int daysAdmitted;

    public int RoomNumber
    {
        get => roomNumber;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Room no. cannot be negative.");
            }
            roomNumber = value;
        }
    }

    public int DaysAdmitted
    {
        get => daysAdmitted;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Room no. cannot be negative.");
            }
            daysAdmitted = value;
        }
    }

    public InPatient(string name, int age, Doctor doctor, int roomNumber, int daysAdmitted)
        : base(name, age, doctor)
    {
        RoomNumber = roomNumber;
        DaysAdmitted = daysAdmitted;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Patient Type: In-Patient");
        Console.WriteLine($"Room Number: {RoomNumber}");
        Console.WriteLine($"Days Admitted: {DaysAdmitted}");
    }
}

#endregion

#region OutPatient.cs

public sealed class OutPatient : Patient
{
    private DateTime visitDate;

    public DateTime VisitDate
    {
        get => visitDate;
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Visit date cannot be in the future.");
            }
            visitDate = value;
        }
    }

    public OutPatient(string name, int age, Doctor doctor, DateTime visitDate)
        : base(name, age, doctor)
    {
        VisitDate = visitDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Patient Type: Out-Patient");
        Console.WriteLine($"Visit Date: {VisitDate:yyyy-MM-dd}");
    }
}

#endregion

#region Bill.cs

public sealed class Bill : IPayable
{
    private readonly string _billNumber;
    private readonly Patient _patient;
    private readonly decimal _amount;
    private bool _isPaid;

    public string BillNumber => _billNumber;
    public Patient Patient => _patient;
    public decimal Amount => _amount;
    public bool IsPaid => _isPaid;

    public Bill(string billNumber, Patient patient, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(billNumber))
            throw new ArgumentException("Bill number cannot be empty.");
        if (patient == null)
            throw new ArgumentNullException(nameof(patient));
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");

        _billNumber = billNumber;
        _patient = patient;
        _amount = amount;
        _isPaid = false;
    }

    public void ProcessPayment()
    {
        if (_isPaid)
        {
            Console.WriteLine($"Bill {_billNumber} is already paid.");
            return;
        }

        _isPaid = true;
        Console.WriteLine($"Payment of ${_amount} processed for {_patient.Name}.");
    }

    public void PrintReceipt()
    {
        Console.WriteLine("=== Payment Receipt ===");
        Console.WriteLine($"Bill Number: {_billNumber}");
        Console.WriteLine($"Patient: {_patient.Name}");
        Console.WriteLine($"Amount: ${_amount:F2}");
        Console.WriteLine($"Status: {(_isPaid ? "PAID" : "UNPAID")}");
        Console.WriteLine("=======================");
    }
}

#endregion

#region Program.cs (Main)

public class Program
{
    public static void Main()
    {
        // Create doctors
        Doctor drSmith = new Doctor("Dr. Sarah Smith", "Cardiology");
        Doctor drJones = new Doctor("Dr. Mark Jones", "General");

        // Create patients
        Patient inPatient = new InPatient("Alice Johnson", 28, drSmith, roomNumber: 305, daysAdmitted: 5);
        Patient outPatient = new OutPatient("Bob Chen", 45, drJones, visitDate: DateTime.Now);

        // Polymorphism demonstration
        inPatient.DisplayInfo();
        Console.WriteLine();
        outPatient.DisplayInfo();
        Console.WriteLine();

        // Create bills
        IPayable inPatientBill = new Bill("B001", inPatient, 15000.00m);
        IPayable outPatientBill = new Bill("B002", outPatient, 2500.00m);

        // Process payment
        inPatientBill.ProcessPayment();
        outPatientBill.ProcessPayment();

        Console.WriteLine();
        inPatientBill.PrintReceipt();
        Console.WriteLine();
        outPatientBill.PrintReceipt();
    }
}

#endregion
