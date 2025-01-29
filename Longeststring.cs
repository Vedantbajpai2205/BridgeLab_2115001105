using System;

class Longeststring
	{
		//method for find the longest word
		public static string Findlongestsubstring(string str)
		{
			string currentWord = "";
			string longestWord = "";
			for(int i=0;i<=str.Length;i++){
				if(i == str.Length || str[i] == ' '){
					if(currentWord.Length > longestWord.Length){
						longestWord = currentWord;
					}
					currentWord = "";
				}
				else{
					currentWord+=str[i];
				}
			}
			return longestWord;
		}
			static void Main(string[] args)
		{
			Console.WriteLine("Enter the string: ");
			string input = Console.ReadLine();
			
			string result = Findlongestsubstring(input);
			Console.WriteLine("Longest SubString is : " + result);
		}
	}