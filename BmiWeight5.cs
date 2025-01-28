using System;

class BmiWeight5
{
    static void Main()
    {
        double[,] persons = new double[10, 3];

        Console.WriteLine("Enter the weight in kg and height in cm  for 10 persons:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nEnter details for person " + (i + 1) + ":");
            Console.Write("Enter weight in kg: ");
            persons[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Enter height in cm: ");
            persons[i, 1] = double.Parse(Console.ReadLine());
        }

        CalculateBMI(persons);

        string[] bmiStatus = DetermineBMIStatus(persons);

        Console.WriteLine("\nDetails of all persons:");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Person | Weight (kg) | Height (cm) | BMI   | Status");

        for (int i = 0; i < 10; i++)
        {
            Console.Write((i + 1) + "," + 6 + "|" + persons[i, 0] + "," + 10 + "|" + persons[i, 1] + "," + 12 + "|" + persons[i, 2] + "," + 5 + "|" + bmiStatus[i]);
        }
    }


    // Method to calculate BMI for each person and populate the third column
    static void CalculateBMI(double[,] persons)
    {
        for (int i = 0; i < 10; i++)
        {
            double heightInMeters = persons[i, 1] / 100; 
            persons[i, 2] = persons[i, 0] / (heightInMeters * heightInMeters); 
        }
    }

    // Method to determine BMI status for each person
    static string[] DetermineBMIStatus(double[,] persons)
    {
        string[] bmiStatus = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = persons[i, 2];
            if (bmi < 18.5)
                bmiStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                bmiStatus[i] = "Normal";
            else if (bmi >= 25 && bmi < 39.9)
                bmiStatus[i] = "Overweight";
            else
                bmiStatus[i] = "Obese";
        }

        return bmiStatus;
    }
}
