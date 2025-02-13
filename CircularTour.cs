using System;

class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int start = 0;
        int currentPetrol = 0;
        int totalPetrol = 0;
        int totalDistance = 0;

        for (int i = 0; i < n; i++)
        {
            totalPetrol += petrol[i];
            totalDistance += distance[i];
            currentPetrol += petrol[i] - distance[i];

            if (currentPetrol < 0)
            {
                start = i + 1;
                currentPetrol = 0;
            }
        }

        if (totalPetrol >= totalDistance)
		{
			return start;
		}
		else
		{
			return -1;
		}
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startPoint = FindStartingPoint(petrol, distance);
        
        if (startPoint != -1)
            Console.WriteLine("The tour starts from petrol pump " + startPoint);
        else
            Console.WriteLine("Not possible");
    }
}
