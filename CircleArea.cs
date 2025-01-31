using System;

    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);  
        }

        // Method to calculate the circumference of the circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius; 
        }

        // Method to display the area and circumference
        public void DisplayDetails()
        {
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + CalculateArea().ToString("F2"));
            Console.WriteLine("Circumference: " + CalculateCircumference().ToString("F2"));
        }
    }

    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);

            circle.DisplayDetails();
        }
    }

