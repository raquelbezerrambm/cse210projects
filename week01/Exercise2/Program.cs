using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter = "";

        // If and else if statements
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        
        else if (gradeInt >= 80 && gradeInt <= 90)
        {
            letter = "B";
        }
        
        else if (gradeInt >= 70 && gradeInt <= 80)
        {
            letter = "C";
        }
        
        else if (gradeInt >= 60 && gradeInt <= 70)
        {
            letter = "D";
        }
        
        else if (gradeInt < 60)
        {
            letter = "F";
        }

        // Writing the letter grade
        Console.WriteLine($"Your letter grade is {letter}");

        // Writing the message
        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed this class!");
        }
        else {
            Console.WriteLine("Sorry, but you did not pass this class. Don't quit, keep going, help and success is ahead.");
        }
    }
}