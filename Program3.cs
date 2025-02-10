using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }

    public string Type
    {
        get { return type; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
    }

    public abstract double CalculateRentalCost(int days);
}

public class Car : Vehicle, IInsurable
{
    public Car(string vehicleNumber, double rentalRate) 
        : base(vehicleNumber, "Car", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.05;
    }

    public string GetInsuranceDetails()
    {
        return "Insurance for Car: 5% of rental rate.";
    }
}

public class Bike : Vehicle, IInsurable
{
    public Bike(string vehicleNumber, double rentalRate) 
        : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.03; 
    }

    public string GetInsuranceDetails()
    {
        return "Insurance for Bike: 3% of rental rate.";
    }
}


public class Truck : Vehicle, IInsurable
{
    public Truck(string vehicleNumber, double rentalRate) 
        : base(vehicleNumber, "Truck", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.07; 
    }

    public string GetInsuranceDetails()
    {
        return "Insurance for Truck: 7% of rental rate.";
    }
}

public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

class Program3
{
    static void Main(string[] args)
    {
        Car car = new Car("C1234", 100);
        Bike bike = new Bike("B5678", 50);
        Truck truck = new Truck("T9876", 200);

        List<Vehicle> vehicles = new List<Vehicle> { car, bike, truck };

        foreach (Vehicle vehicle in vehicles)
        {
            double rentalCost = vehicle.CalculateRentalCost(5);
            Console.WriteLine("Vehicle Type: " + vehicle.Type + " | Vehicle Number: " + vehicle.VehicleNumber + " | Rental Cost for 5 days: " + rentalCost);

            if (vehicle is IInsurable insurableVehicle)
            {
                double insuranceCost = insurableVehicle.CalculateInsurance();
                string insuranceDetails = insurableVehicle.GetInsuranceDetails();
                Console.WriteLine("Insurance Cost: " + insuranceCost);
                Console.WriteLine("Insurance Details: " + insuranceDetails);
            }
            Console.WriteLine();
        }
    }
}
