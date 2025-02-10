using System;

abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    public Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public string GetVehicleDetails()
    {
        return "Vehicle ID: " + vehicleId + ", Driver: " + driverName + ", Rate per Km: " + ratePerKm;
    }

    public abstract double CalculateFare(double distance);
}

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(string vehicleId, string driverName, double ratePerKm, string currentLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = currentLocation;
    }

    public override double CalculateFare(double distance)
    {
        return distance * 15;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(string vehicleId, string driverName, double ratePerKm, string currentLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = currentLocation;
    }

    public override double CalculateFare(double distance)
    {
        return distance * 10; 
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(string vehicleId, string driverName, double ratePerKm, string currentLocation)
        : base(vehicleId, driverName, ratePerKm)
    {
        this.currentLocation = currentLocation;
    }

    public override double CalculateFare(double distance)
    {
        return distance * 12; 
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

class Program8
{
    public static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("C001", "Yash", 15, "Downtown"),
            new Bike("B001", "Vedant", 10, "Uptown"),
            new Auto("A001", "Raghav", 12, "Midtown")
        };

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle.GetVehicleDetails());
            double distance = 10;
            Console.WriteLine("Fare for " + distance + " Km: " + vehicle.CalculateFare(distance));

            if (vehicle is IGPS gpsVehicle)
            {
                Console.WriteLine("Current Location: " + gpsVehicle.GetCurrentLocation());
                gpsVehicle.UpdateLocation("New Location");
                Console.WriteLine("Updated Location: " + gpsVehicle.GetCurrentLocation());
            }

            Console.WriteLine();
        }
    }
}
