using System;

public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you learned something new."
        };

        _questions = new List<string>
        {
            "What did you learn from this experience?",
            "How did this experience change you?",
            "What would you do differently next time?",
            "How can you apply what you learned in the future?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"Reflect on this prompt: {GetRandomPrompt()}");
        ShowSpinner(3);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Take a moment to reflect on the following questions:");
        foreach (var question in _questions)
        {
            Console.WriteLine($"- {question}");
            ShowSpinner(5); // Simulate time for reflection
        }
    }

    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        DisplayPrompt();
        ShowCountdown(_duration);
        DisplayQuestions();
        DisplayEndMessage();
    }
}