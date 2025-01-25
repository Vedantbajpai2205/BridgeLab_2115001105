using System;

class Singledimension
{
	//method for convert a 2d array into single dimension array
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
		int rows = int.Parse(Console.ReadLine());
        if (rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for rows.");
            return;
        }

        Console.Write("Enter the number of columns: ");
		int columns = int.Parse(Console.ReadLine());
        if (columns <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for columns.");
            return;
        }

        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element : " + " [" + i + " , " + j + " ] :");
                if (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    j--; 
                }
            }
        }

        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("\nThe elements of the 1D array are:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
    }
}