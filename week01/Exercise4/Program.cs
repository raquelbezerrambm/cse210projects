using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;
        int sumNumbers = 0;

        // Declaring list
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            string inputN = Console.ReadLine();
            input = int.Parse(inputN);
            
            if (input != 0)
            {
                // Append each one to a list (Stop when they enter 0)
                numbers.Add(input);
            }

        }while (input != 0);

        // Compute the sum, or total, of the numbers in the list.
        foreach (int number in numbers)
        {
            sumNumbers += number; 
        }
        Console.WriteLine($"The sum is: {sumNumbers}");

        // Compute the average of the numbers in the list.
        int length = numbers.Count;
        double average = sumNumbers / length;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list.
        int largest = 0;
        
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }   
}