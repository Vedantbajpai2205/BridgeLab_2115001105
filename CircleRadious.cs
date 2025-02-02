using System;

class Circle
{
    public double Radius { get; set; }

    public Circle() : this(1.0) 
    {
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayArea()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine("Circle with radius " + Radius + " has an area of " + area.ToString("F2"));
    }
}

class CircleRadious
{
    static void Main()
    {
        Circle circle1 = new Circle();
        circle1.DisplayArea();

        Console.WriteLine();

        Circle circle2 = new Circle(5.0);
        circle2.DisplayArea();
    }
}
