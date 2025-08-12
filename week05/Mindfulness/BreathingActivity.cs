using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
    }
    public BreathingActivity()
        : base("Breathing", "Focus on your breath: An activity to help you relax", 5)
    {
    }
    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        ShowCountdown(_duration);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Now Breathe out...");
            ShowCountdown(5);
        }
        ShowSpinner(5);
        DisplayEndMessage();
    }
}