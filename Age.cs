using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Age
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException)
        {
            Console.WriteLine("Age must be 18 or above.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age is below 18.");
        }
    }
}
