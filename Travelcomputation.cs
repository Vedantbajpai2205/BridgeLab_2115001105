using System;

namespace EricTravels
{
    class Travelcomputation
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine();

            Console.Write("Enter the city you travel via: ");
            string viaCity = Console.ReadLine();

            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine();

            Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " (in miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the distance from " + viaCity + " to " + toCity + " (in miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time taken from " + fromCity + " to " + viaCity + " (in hours): ");
            double timeFromToVia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time taken from " + viaCity + " to " + toCity + " (in hours): ");
            double timeViaToFinalCity = Convert.ToDouble(Console.ReadLine());
			
			//calculate the total distance and totaltime
            double totalDistance = fromToVia + viaToFinalCity;
            double totalTime = timeFromToVia + timeViaToFinalCity;

            Console.WriteLine("The results of the trip are:");
            Console.WriteLine("Total distance: " + totalDistance + " miles");
            Console.WriteLine("Total time: " + totalTime + " hours");
        }
    }
}