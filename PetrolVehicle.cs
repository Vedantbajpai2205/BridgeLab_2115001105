using System;

public interface IRefuelable
{
    void Refuel();
}

public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Vehicle Model: " + Model + ", Max Speed: " + MaxSpeed + " km/h.");
    }
}

public class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }

    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
        : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine(Model + " is charging. Battery capacity: " + BatteryCapacity + " kWh.");
    }
}

public class PetrolVehicle : Vehicle, IRefuelable
{
    public string FuelType { get; set; }

    public PetrolVehicle(int maxSpeed, string model, string fuelType)
        : base(maxSpeed, model)
    {
        FuelType = fuelType;
    }

    public void Refuel()
    {
        Console.WriteLine(Model + " is refueling with " + FuelType + ".");
    }
    public static void Main(string[] args)
    {
        ElectricVehicle ev = new ElectricVehicle(150, "Tata Punch", 100);
        PetrolVehicle pv = new PetrolVehicle(120, "Wagon r", "Petrol");

        Console.WriteLine("Electric Vehicle Info:");
        ev.DisplayInfo();
        ev.Charge();
        Console.WriteLine();

        Console.WriteLine("Petrol Vehicle Info:");
        pv.DisplayInfo();
        pv.Refuel();
    }
}
