using System;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription, duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "List your favorite verses you have studied this week.",
            "List your top 5 happy moments today.",
            "List your goals for the next year.",
            "List things you are grateful for.",
            "List how God has blessed you recently."
        };
    }
    public ListingActivity()
        : base("Listing", "List your thoughts", 5)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "List your favorite verses you have studied this week.",
            "List your top 5 happy moments today.",
            "List your goals for the next year.",
            "List things you are grateful for.",
            "List how God has blessed you recently."
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Please enter your items (type 'done' to finish):");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                userList.Add(input);
                _count++;
            }
        }
        return userList;
    }

    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(3);
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        ShowCountdown(_duration);
        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndMessage();
    }


}