using System;

class Palindrome
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the String: ");
			String input = Console.ReadLine();
			input = input.ToLower();
			string reverse = "";
			char[] charArray = input.ToCharArray();
			for(int i = charArray.Length-1; i>=0;i--){
				reverse += charArray[i];
			}
			if(reverse==input)
			{
				Console.WriteLine("Given String is Palindrome.");
			}
			else{
				Console.WriteLine("String is not Palindrome.");
			}
		}
	}	