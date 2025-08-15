using System;
using System.Collections.Generic;
using System.IO;

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
                    // This is where you'd instantiate SimpleGoal, EternalGoal, etc.
                    break;
                case "2":
                    // Logic to list goals.
                    // You can loop through the goals list and call the GetDetailsString() method on each one.
                    break;
                case "3":
                    // Logic to record an event.
                    // You'd ask the user which goal to record and then call its RecordEvent() method.
                    break;
                case "4":
                    // Logic to save goals to a file.
                    // You'd loop through the goals and call GetStringRepresentation() to write to the file.
                    break;
                case "5":
                    // Logic to load goals from a file.
                    // You'd read the file, split the string, and use the first part to determine which type of goal to create.
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