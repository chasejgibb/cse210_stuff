using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        Console.Write("Guess a number from 1 to 100! ");
        string guessStr = Console.ReadLine();
        int guess = int.Parse(guessStr);
        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            Console.Write("Try again: ");
            guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);
        }
        Console.Write("Nice job! You guessed it! :D");
    }
}