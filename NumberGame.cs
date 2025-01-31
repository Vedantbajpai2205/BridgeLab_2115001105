using System;

class NumberGame
{
	//Number guess by computer and feeedback by user
    static void Main()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Think of a number between 1 and 100 and I will try to guess it.");
        Console.WriteLine("Please provide feedback on each guess: 'too high', 'too low', or 'correct'.");

        PlayGame();
    }

    static void PlayGame()
    {
        int lowerBound = 1;
        int upperBound = 100;
        int guess;
        string feedback;

        while (true)
        {
            guess = GenerateGuess(lowerBound, upperBound);
            Console.WriteLine("My guess is: " + guess);

            feedback = GetUserFeedback();
            
            if (feedback.ToLower() == "correct")
            {
                Console.WriteLine("Yay! I guessed the correct number!");
                break;
            }
            else if (feedback.ToLower() == "too high")
            {
                upperBound = guess - 1;
            }
            else if (feedback.ToLower() == "too low")
            {
                lowerBound = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input! Please respond with 'too high', 'too low', or 'correct'.");
            }
        }
    }

    static int GenerateGuess(int lowerBound, int upperBound)
    {
        Random random = new Random();
        return random.Next(lowerBound, upperBound + 1); // +1 because upperBound is inclusive
    }

    static string GetUserFeedback()
    {
        Console.WriteLine("Is the guess too high, too low, or correct?");
        return Console.ReadLine();
    }
}
