using System;

class Patient
{
    public string Name;

    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name;

    public Doctor(string name)
    {
        Name = name;
    }

    // doctor communicates with patient
    public void Consult(Patient patient)
    {
        Console.WriteLine("Doctor " + Name + " is consulting " + patient.Name);
    }
}

class Hospital
{
    public string HospitalName;

    public Hospital(string name)
    {
        HospitalName = name;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter hospital name: ");
        Hospital hospital = new Hospital(Console.ReadLine());

        Console.Write("Enter doctor name: ");
        Doctor doctor = new Doctor(Console.ReadLine());

        Console.Write("Enter patient name: ");
        Patient patient = new Patient(Console.ReadLine());

        doctor.Consult(patient);
    }
}
