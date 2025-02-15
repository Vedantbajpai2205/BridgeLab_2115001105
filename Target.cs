using System;

class Target
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows in the matrix:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the matrix:");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the target value to search for:");
        int target = int.Parse(Console.ReadLine());

        bool found = SearchInMatrix(matrix, target);

        if (found)
        {
            Console.WriteLine("Target found in the matrix.");
        }
        else
        {
            Console.WriteLine("Target not found in the matrix.");
        }
    }

    static bool SearchInMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = (rows * cols) - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midElement = matrix[mid / cols, mid % cols];

            if (midElement == target)
            {
                return true;
            }
            else if (midElement < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}
