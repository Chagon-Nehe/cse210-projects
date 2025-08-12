using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
    }
    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        ShowCountdown(_duration);
        Console.WriteLine($"Breathe in...");
        ShowCountdown(5);
        Console.WriteLine("Breathe out... ");
        ShowSpinner(5);
        Console.WriteLine("Breathe in... ");
        ShowCountdown(5);
        Console.WriteLine("Breathe out... ");
        ShowSpinner(5);
        Console.WriteLine("Breathe in... ");
        ShowCountdown(5);
        Console.WriteLine("Breathe out... ");
        ShowSpinner(5);
        DisplayEndMessage();
    }
}