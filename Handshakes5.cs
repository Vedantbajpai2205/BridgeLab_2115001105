using System;

class Handshakes5
{
    // Method to calculate the number of handshakes using combination formula
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);

        Console.WriteLine("The maximum number of handshakes among " + students + " students is: " + handshakes);
    }
}
