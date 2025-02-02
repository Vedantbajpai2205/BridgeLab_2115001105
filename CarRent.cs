using System;

class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; }

    public CarRental()
    {
        CustomerName = "Unknown";
        CarModel = "Unknown";
        RentalDays = 0;
        DailyRate = 50.0; 
    }

    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRate = dailyRate;
    }

    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    public void DisplayRentalInfo()
    {
        Console.WriteLine("Customer Name: " + CustomerName);
        Console.WriteLine("Car Model: " + CarModel);
        Console.WriteLine("Rental Days: " + RentalDays);
        Console.WriteLine("Daily Rate: " + DailyRate.ToString("F2"));
        Console.WriteLine("Total Cost: " + CalculateTotalCost().ToString("F2"));
    }
}

class CarRent
{
    static void Main()
    {
        CarRental rental1 = new CarRental();
        Console.WriteLine("Rental 1 (Default Constructor):");
        rental1.DisplayRentalInfo();

        Console.WriteLine();

        CarRental rental2 = new CarRental("John Doe", "Toyota Corolla", 7, 40.0);
        Console.WriteLine("Rental 2 (Parameterized Constructor):");
        rental2.DisplayRentalInfo();
    }
}
