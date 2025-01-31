using System;

    class CheckTemp
    {
        // Main function to check temperature
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.Write("Choose an option 1 or 2: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                double fahrenheit = GetTemperatureInput("Enter temperature in Fahrenheit: ");
                double celsius = FahrenheitToCelsius(fahrenheit);
                DisplayResult(fahrenheit, celsius, "Fahrenheit", "Celsius");
            }
            else if (choice == 2)
            {
                double celsius = GetTemperatureInput("Enter temperature in Celsius: ");
                double fahrenheit = CelsiusToFahrenheit(celsius);
                DisplayResult(celsius, fahrenheit, "Celsius", "Fahrenheit");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }

        static double GetTemperatureInput(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

       
        static void DisplayResult(double input, double output, string fromUnit, string toUnit)
        {
            Console.WriteLine(input + " degrees " + fromUnit + " is equal to " + output + " degrees " + toUnit);
        }
    }
