using System;

class Multiple
{
    static void Main()
    {
        try
        {
            int[] arr = null;
            int index = 2;
            
            if (arr == null)
            {
                throw new NullReferenceException();
            }
            Console.WriteLine("Value at index {0}: {1}", index, arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}
