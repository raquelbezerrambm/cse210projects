using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Using a Random Generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,1001);

        int guessedNumber = -1;

        do
        {
            // Asking the user for the guess
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            
            // If the guessed number is greater than the magic number
            if (guessedNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        
            // If the person guessed the correct number
            else if (guessedNumber == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }

            // If the guessed number is lower than the magic number
            else
        {
            Console.WriteLine("Higher");
        }
        } while ( guessedNumber != magicNumber);
    }
}