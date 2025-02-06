using System;
using System.Collections.Generic;

class Patient
{
	public string Name{get; set;}
	public List<Doctor> doctors = new List<Doctor>();
	
	public Patient(string name)
	{
		Name = name;
	}
	public void Display()
	{
		Console.WriteLine("patient's : " + Name);
	}
	public void AddDoctor(Doctor doctor)
	{
		doctors.Add(doctor);
	}
}
class Doctor
{
	public string DoctorName{get; set;}
	public List<Patient> patients = new List<Patient>();
	
	public Doctor(string doctorname)
	{
		DoctorName = doctorname;
	}
	public void DisplayDoctor()
	{
		Console.WriteLine("Doctors's : " + DoctorName);
	}
	public void AddPatient(Patient patient)
	{
		patients.Add(patient);
	}
	public void Consult(Patient patient)
	{
		Console.WriteLine(DoctorName + " is consulting " + patient.Name);
		Console.WriteLine("Doctor: How Are You Feeling Today, " + patient.Name + " ? ");
	}
}
class Hospital
{
	public string HospitalName{get; set;}
	public List<Doctor> doctors = new List<Doctor>();
	public List<Patient> patients = new List<Patient>();
	public Hospital(string hospitalname)
	{
		HospitalName = hospitalname;
		Console.WriteLine("Hospital Name :" + HospitalName);
	}
	public void AddDoctor(Doctor doctor)
	{
		if(!doctors.Contains(doctor))
		{
		doctors.Add(doctor);
		}
	}
	public void AddPatient(Patient patient)
	{
		if(!patients.Contains(patient))
		{
		patients.Add(patient);
		}
	}
	static void Main(string[] args)
	{
		Hospital hospital = new Hospital("Yo Hospital");
		
		Doctor doctor1 = new Doctor("Dr. Yash");
		Doctor doctor2 = new Doctor("Dr. Vedant");
		
		Patient patient1 = new Patient("XYZ");
		Patient patient2 = new Patient("abc");

		hospital.AddDoctor(doctor1);
		hospital.AddDoctor(doctor2);
		hospital.AddPatient(patient1);
		hospital.AddPatient(patient2);
		
		doctor1.Consult(patient1);
		doctor2.Consult(patient2);
		
		patient1.AddDoctor(doctor1);
		patient2.AddDoctor(doctor2);
		
		Console.WriteLine(patient1.Name + " has consulted by folllowing doctor.");
		foreach(var doctor in patient1.doctors)
		{
			Console.WriteLine(doctor.DoctorName);
		}
		Console.WriteLine(patient2.Name + " has consulted by folllowing doctor.");
		foreach(var doctor in patient2.doctors)
		{
			Console.WriteLine(doctor.DoctorName);
		}
		patient1.Display();
		patient2.Display();
	}
}