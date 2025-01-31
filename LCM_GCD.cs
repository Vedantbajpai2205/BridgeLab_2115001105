using System;

namespace GCD_LCM_Calculator
{
    class LCM_GCD
    {
        static void Main(string[] args)
        {
           
            int num1 = GetInput("Enter the first number: ");
            int num2 = GetInput("Enter the second number: ");

            int gcd = CalculateGCD(num1, num2);

            int lcm = CalculateLCM(num1, num2, gcd);

            DisplayResults(gcd, lcm);
        }

        static int GetInput(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        // Function to calculate the GCD 
        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Function to calculate the LCM using the formula: LCM(a, b) = |a * b| / GCD(a, b)
        static int CalculateLCM(int a, int b, int gcd)
        {
            return Math.Abs(a * b) / gcd;
        }

        static void DisplayResults(int gcd, int lcm)
        {
            Console.WriteLine("The GCD is: " + gcd);
            Console.WriteLine("The LCM is: " + lcm);
        }
    }
}
