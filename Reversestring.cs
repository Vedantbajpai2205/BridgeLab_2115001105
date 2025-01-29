using System;

class Reversestring
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
			Console.WriteLine("Reverese String : " + reverse);
		}
	}	