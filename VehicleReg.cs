using System;

class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    public static double RegistrationFee = 100.0;  

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Fee: " + RegistrationFee.ToString("F2"));
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration fee updated to: " + RegistrationFee.ToString("F2"));
    }
}

class VehicleReg
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle("Alice", "Car");
        Vehicle vehicle2 = new Vehicle("Bob", "Motorcycle");
        Vehicle vehicle3 = new Vehicle("Charlie", "Truck");

        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Vehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();
        Console.WriteLine();

        Vehicle.UpdateRegistrationFee(120.0);

        Console.WriteLine("\nAfter updating the registration fee:");

        Console.WriteLine("Vehicle 1 Details:");
        vehicle1.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Details:");
        vehicle2.DisplayVehicleDetails();
        Console.WriteLine();

        Console.WriteLine("Vehicle 3 Details:");
        vehicle3.DisplayVehicleDetails();
    }
}
