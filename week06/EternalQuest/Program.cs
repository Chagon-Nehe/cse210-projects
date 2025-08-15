using System;
using System.Collections.Generic;
using System.IO;
using Goals;

public class Program
{
    public static void Main(string[] args)
    {
        // List to hold all goal objects.
        List<Goal> goals = new List<Goal>();
        int score = 0;
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine($"\nYour Current Score: {score} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Logic to create a new goal based on user input.
                    Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
                    string goalType = Console.ReadLine().ToLower();
                    // This is where you'd instantiate SimpleGoal, EternalGoal, etc.
                   
                    if (goalType == "simple" || goalType == "eternal" || goalType == "checklist")
                    {
                        Console.WriteLine($"Creating a new {goalType} goal.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type. Please enter 'Simple', 'Eternal', or 'Checklist'.");
                        continue;
                    }
                    if (goalType == "simple")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter points for the goal: ");
                        int points = int.Parse(Console.ReadLine());
                        goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "eternal")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter points for the goal: ");
                        int points = int.Parse(Console.ReadLine());
                        goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "checklist")
                    {
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter points for the goal: ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("Enter target amount to complete: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points for completion: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;
                case "2":
                    // Logic to list goals.
                    Console.WriteLine("\nGoals List:");
                    if (goals.Count == 0)
                        // You can loop through the goals list and call the GetDetailsString() method on each one.
                        Console.WriteLine("No goals available.");
                    else
                    {
                        foreach (Goal goal in goals)
                        {
                            Console.WriteLine(goal.GetDetailsString());
                        }
                    }
                    break;
                case "3":
                    // Logic to record an event.
                    Console.WriteLine("Select a goal to record an event:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
                    }
                    // You'd ask the user which goal to record and then call its RecordEvent() method.
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    if (goalIndex >= 0 && goalIndex < goals.Count)
                    {
                        goals[goalIndex].RecordEvent();
                        if (goals[goalIndex].IsComplete())
                        {
                            score += goals[goalIndex].GetPoints();
                            Console.WriteLine($"Goal '{goals[goalIndex].GetDetailsString()}' completed! You earned {goals[goalIndex].GetPoints()} points.");
                        }
                        else
                        {
                            Console.WriteLine($"Event recorded for goal: {goals[goalIndex].GetDetailsString()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal selection.");
                    }
                    break;
                case "4":
                    // Logic to save goals to a file.
                    Console.Write("Enter filename to save goals: ");
                    string filename = Console.ReadLine();
                    // You'd loop through the goals and call GetStringRepresentation() to write to the file.
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (Goal goal in goals)
                        {
                            writer.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;
                case "5":
                    // Logic to load goals from a file.
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    // You'd read the file, split the string, and use the first part to determine which type of goal to create.
                    if (File.Exists(loadFilename))
                    {
                        using (StreamReader reader = new StreamReader(loadFilename))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] parts = line.Split(',');
                                if (parts[0] == "SimpleGoal")
                                {
                                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                                }
                                else if (parts[0] == "EternalGoal")
                                {
                                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                                }
                                else if (parts[0] == "ChecklistGoal")
                                {
                                    goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                                }
                            }
                        }
                        Console.WriteLine("Goals loaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}