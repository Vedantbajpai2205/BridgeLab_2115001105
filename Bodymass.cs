using System;

class Bodymass
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] weightStatuses = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nPerson :" + (i+1));
            Console.Write("Enter weight in kg: ");
            weights[i] = double.Parse(Console.ReadLine());
            Console.Write("Enter height in meters: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = CalculateBMI(weights[i], heights[i]);
            weightStatuses[i] = DetermineWeightStatus(bmis[i]);
        }

        Console.WriteLine("\n{0,-10} {1,-10} {2,-10} {3,-15}", "Height(m)", "Weight(kg)", "BMI", "Weight Status");
        Console.WriteLine(new string('-', 60));

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("{0,-10:F2} {1,-10:F2} {2,-10:F2} {3,-15}", heights[i], weights[i], bmis[i], weightStatuses[i]);
        }
    }

    // Method to calculate BMI
    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    // Method to determine weight status based on BMI
    static string DetermineWeightStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Normal weight";
        else if (bmi >= 25 && bmi < 39.9)
            return "Overweight";
        else
            return "Obesity";
    }
}