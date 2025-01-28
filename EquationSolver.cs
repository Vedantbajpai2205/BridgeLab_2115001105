using System;

class EquationSolver
{
    static void Main(string[] args)
    {
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots != null)
        {
            Console.WriteLine("The roots of the equation are: ");
            foreach (double root in roots)
            {
                Console.WriteLine("x = " + root);
            }
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
        }
    }

    // Method to find the roots of the quadratic equation
    static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) + 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return null;
        }
    }
}
