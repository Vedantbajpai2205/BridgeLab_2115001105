using System;

class Handshakes5_3
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is: " + handshakes);
    }
}
