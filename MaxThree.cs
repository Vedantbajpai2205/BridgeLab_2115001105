using System;

class MaxThree{
	static void Main(string[] args)
	{
		int num1 = Takeinput("Enter first numbers: ");
		int num2 = Takeinput("Enter Second numbers: ");
		int num3 = Takeinput("Enter Three numbers: ");
		
		int maxNumber = FindMaximum(num1, num2, num3);

        Console.WriteLine("The maximum value is: " + maxNumber);
		
	}
	static int Takeinput(string prompt)
	{
		Console.Write(prompt);
		 int number = int.Parse(Console.ReadLine());
         return number;
	}
	static int FindMaximum(int num1,int num2,int num3)
	{
		int max = num1;
		if(num2>max){
			max = num2;
		}
		if(num3>max)
		{
			max = num3;
		}
		return max;
	}
}