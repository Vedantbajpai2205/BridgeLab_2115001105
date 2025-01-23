using System;

class Tallest
{
	//method for finding tallest in three friends
    static void Main()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        if (youngestAge == amarAge)
        {
            Console.WriteLine("Amar is the youngest.");
        }
        else if (youngestAge == akbarAge)
        {
            Console.WriteLine("Akbar is the youngest.");
        }
        else
        {
            Console.WriteLine("Anthony is the youngest.");
        }
     
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        if (tallestHeight == amarHeight)
        {
            Console.WriteLine("Amar is the tallest.");
        }
        else if (tallestHeight == akbarHeight)
        {
            Console.WriteLine("Akbar is the tallest.");
        }
        else
        {
            Console.WriteLine("Anthony is the tallest.");
        }
    }
}