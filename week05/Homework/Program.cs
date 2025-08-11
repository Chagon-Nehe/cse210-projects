using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Alice Smith", "Math Homework");
        MathAssingment mathAssignment1 = new MathAssingment("Alice Smith", "Algebra", "Section 5.2", "Problems 1-10");
        WritingAssignment writingAssignment1 = new WritingAssignment("Alice Smith", "History", "The American Revolution");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine(writingAssignment1.GetSummary());
    }
}