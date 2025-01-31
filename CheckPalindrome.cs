using System;
class CheckPalindrome
{
	static void Main(string[] args)
	{
		string input = Takeinput();
		bool result = CheckWordisPalindrome(input);
		
		DisplayResult(result);

	}
	static string Takeinput()
	{
		Console.WriteLine("Enter the Word or Phrase: ");
		string res = Console.ReadLine();
		return res.ToLower();
		
	}
	static bool CheckWordisPalindrome(string input)
	{
		string revString = "";
		for(int i=input.Length-1;i>=0;i--)
		{
			revString += input[i]; 
		}
			if(revString==input)
			{
				return true;
			}
			else{
				return false;
			}
	}
	static void DisplayResult(bool CheckWordisPalindrome)
    {
        if (CheckWordisPalindrome)
        {
            Console.WriteLine("The given string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The given string is not a palindrome.");
        }
    }
}