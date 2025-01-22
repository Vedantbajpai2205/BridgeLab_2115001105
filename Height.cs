using System;

class Height
{
	//Method for Calculate the height in inches
	public static void heightInch()
	{
		
		Console.Write("Enter your height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());
        double cmPerInch = 2.54;
        double inchesPerFoot = 12;
		
        // Convert height in centimeters to inches
        double heightInInches = heightInCm / cmPerInch;

        // Convert inches to feet and remaining inches
        int feet = (int)(heightInInches / inchesPerFoot);
        int inches = (int)(heightInInches % inchesPerFoot);
	}
    static void Main(string[] args)
    {
        Height.heightInch();
    }
}