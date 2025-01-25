using System;

class Bodymass2d
{
	//method for calculate the bodymass of person
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons;
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.Write("Please enter a valid positive integer: ");
        }

        double[][] personData = new double[numberOfPersons][];
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i] = new double[3]; 
        }
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("\nEnter details for Person :" + (i+1));

            Console.Write("Height in meters: ");
            while (!double.TryParse(Console.ReadLine(), out personData[i][0]) || personData[i][0] <= 0)
            {
                Console.Write("Please enter a valid positive height: ");
            }

            Console.Write("Weight in kilograms: ");
            while (!double.TryParse(Console.ReadLine(), out personData[i][1]) || personData[i][1] <= 0)
            {
                Console.Write("Please enter a valid positive weight: ");
            }

            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);

            // Step 5: Determine weight status
            if (personData[i][2] <= 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i][2] <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i][2] <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        Console.WriteLine("\n{0,-10} {1,-10} {2,-10} {3,-15}", "Height(m)", "Weight(kg)", "BMI", "Weight Status");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("{0,-10:F2} {1,-10:F2} {2,-10:F2} {3,-15}", personData[i][0], personData[i][1], personData[i][2], weightStatus[i]);
        }
    }
}
