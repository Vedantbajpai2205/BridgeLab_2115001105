using System;

class Toggle
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the String: ");
		string input = Console.ReadLine();
		char[] chars = input.ToCharArray();
		for(int i=0;i<chars.Length;i++){
			if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                chars[i] = (char)(chars[i] - 'a' + 'A');
            }
            else if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                chars[i] = (char)(chars[i] - 'A' + 'a');
            }
		}
		Console.WriteLine("String after toggle: " + new string(chars));
	}
}