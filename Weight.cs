using System;

class Weight
{
	//method for calculate weight in pounds
	public static void weightPounds()
	{
		Console.Write("Enter weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // According to question: 1 pound = 2.2 kilograms
        double weightInkgs = weightInPounds * 2.2 ;
		
		Console.WriteLine("The weight of the person in pounds is " + weightInPounds + "and in kg is " + weightInkgs);
		
	}
	static void Main(string[] args)
    {
        Weight.weightPounds();
    }
}