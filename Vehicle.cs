using System;
class Vehicle
{
    public static int RegistartionFee;
    public string Ownername{get; set;}
    private readonly int RegistrationNumber;
    public string Vehicletype{get; set;}
  
    public static void UpdateRegistartionfee(int Fee)
    {
        RegistartionFee=Fee;
        Console.WriteLine("Updated Registration Fee :" + RegistartionFee);
    }
    public Vehicle(string ownername, int registrationnumber, string vehicletype)
    {
        this.Ownername = ownername;
        this.RegistrationNumber = registrationnumber;
        this.Vehicletype = vehicletype;
    }
    public void DisplayVehicledetails()
    {
        if (this is Vehicle)
        {

            Console.WriteLine("Owner Name :" + Ownername);
            Console.WriteLine("Registartion Number :" + RegistrationNumber);
            Console.WriteLine("Vehicle type :" + Vehicletype);
        }
    }
    static void Main()
    {
        Vehicle v1 = new Vehicle("Yash",1234 , "Petrol");
        Vehicle v2 = new Vehicle("Vedant", 5678, "Diesel");
        v1.DisplayVehicledetails();
        UpdateRegistartionfee(5000);
        Console.WriteLine();
        v2.DisplayVehicledetails();
        UpdateRegistartionfee(4000);
    }
}