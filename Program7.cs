using System;
using System.Collections.Generic;

abstract class Patient
{
    protected string patientId;
    protected string name;
    protected int age;

    public Patient(string patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public string GetPatientDetails()
    {
        return "Patient ID: " + patientId + ", Name: " + name + ", Age: " + age;
    }

    public abstract double CalculateBill();
}

interface IMedicalRecord
{
    void AddRecord(string record);
    List<string> ViewRecords();
}

class InPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords;
    private double roomCharge;

    public InPatient(string patientId, string name, int age, double roomCharge) : base(patientId, name, age)
    {
        this.roomCharge = roomCharge;
        medicalRecords = new List<string>();
    }

    public override double CalculateBill()
    {
        return roomCharge + 1000; 
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public List<string> ViewRecords()
    {
        return medicalRecords;
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords;

    public OutPatient(string patientId, string name, int age) : base(patientId, name, age)
    {
        medicalRecords = new List<string>();
    }

    public override double CalculateBill()
    {
        return 1000; 
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public List<string> ViewRecords()
    {
        return medicalRecords;
    }
}

class Program7
{
    public static void Main(string[] args)
    {
        Patient[] patients = new Patient[]
        {
            new InPatient("I001", "Yash", 45, 1500),
            new OutPatient("O001", "Vedant", 30)
        };

        foreach (Patient patient in patients)
        {
            Console.WriteLine(patient.GetPatientDetails());
            Console.WriteLine("Bill Amount: " + patient.CalculateBill());

            if (patient is IMedicalRecord recordablePatient)
            {
                recordablePatient.AddRecord("Diagnosis: Fever");
                recordablePatient.AddRecord("Prescription: Paracetamol");

                Console.WriteLine("Medical Records:");
                foreach (var record in recordablePatient.ViewRecords())
                {
                    Console.WriteLine(record);
                }
            }

            Console.WriteLine();
        }
    }
}
