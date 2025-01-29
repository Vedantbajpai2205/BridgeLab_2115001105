using System;
class Compare
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter First String: ");
		string str1 = Console.ReadLine();
		
		Console.WriteLine("Enter second String: ");
		string str2 = Console.ReadLine();
		
		str1 = str1.ToLower();
		str2 = str2.ToLower();
		
		int minLength = Math.Min(str1.Length,str2.Length);
		for(int i=0;i<minLength;i++){
		if(str1[i] < str2[i])
			{
				Console.WriteLine(str1 + " comes before " + str2 + " in lexicographical order");
				return;
			}
		else if(str1[i] > str2[i])
		{
			Console.WriteLine(str2 + " comes before " + str1 + " in lexicographical order");
			return;
		}
		}
	}
}