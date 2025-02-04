using System;

class Patient
{
    public static string HospitalName = "Yo Hospital";
    
    private static int totalPatients = 0;
    
    private readonly int PatientID;
    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }
    
    public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = ++totalPatients; 
    }
    
    public static int GetTotalPatients()
    {
        return totalPatients;
    }
    
    public void DisplayDetails()
    {
        if (this is Patient) 
        {
            Console.WriteLine("Patient Name: " + Name);
			Console.WriteLine("Patient Age: " + Age);
			Console.WriteLine("Patient Ailment: " + Ailment);
			Console.WriteLine("Patient ID: " + PatientID);
        }
		else
		{
			Console.WriteLine("Invalid Details! please enter correct details.");
		}
    }
    static void Main()
    {
        Patient p1 = new Patient("Xyz", 30, "Corona");
        Patient p2 = new Patient("Abc", 25, "Fever");
        
        p1.DisplayDetails();
		Console.WriteLine();
        p2.DisplayDetails();
        
        Console.WriteLine("\nTotal Patients Admitted: " + Patient.GetTotalPatients());
    }
}