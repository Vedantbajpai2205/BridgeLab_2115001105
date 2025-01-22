using System;

class Handshakes
{
	//Method for find the total number of handshakes
	public static void numofHandshakes()
	{
		
		Console.Write("Enter the number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the combination formula
        int handshakes = (n * (n - 1)) / 2;
		
		Console.WriteLine("The max num of handshakes is " + handshakes + " while the num of student is " + n);
	}
    static void Main(string[] args)
    {
        Handshakes.numofHandshakes();
    }
}