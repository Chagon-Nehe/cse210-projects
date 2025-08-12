using System;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration;

    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_activityName} for {_duration} seconds.");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(2);
        Console.WriteLine($"Ending {_activityName}. Hope you enjoyed it!");
    }
    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // Simulate loading
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i} seconds remaining.");
            System.Threading.Thread.Sleep(1000); // Simulate countdown
        }
        Console.WriteLine("Countdown complete!");
    }


}
