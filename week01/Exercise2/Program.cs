using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?. ");
        string userValue = Console.ReadLine();
        int gradePercent = int.Parse(userValue); // Convert the input to an integer
        string gradeLetter;
        if (gradePercent >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your grade is {gradeLetter}.");
        // Check if the user passed or failed
        // A passing grade is 70% or higher
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations You passed the course!");

        }
        else
        {
            Console.WriteLine("Sorry! You did not pass the course. Please keep pushing.");
        }
    }
}