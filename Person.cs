using System;

class Person
{
	//method for calculate bmi of person
    static void Main()
    {
        Console.Write("Enter your weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;

        double bmi = weight / (heightM * heightM);

        Console.WriteLine("Your BMI is: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi <= 39.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }
}