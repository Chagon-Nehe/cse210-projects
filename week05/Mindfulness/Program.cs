using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Mindfulness App

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Menu:");
            Console.WriteLine(      "1. Start Breathing Activity");
            Console.WriteLine(      "2. Start Reflection Activity");
            Console.WriteLine(      "3. Start Listing Activity");
            Console.WriteLine(      "4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Focus on your breath: An activity to help you relax", 5);
                    breathingActivity.Run();

                    break;
                case "2":
                    // ReflectionActivity reflectionActivity 
                    ReflectingActivity reflectionActivity = new ReflectingActivity("Reflection", "Reflect on your thoughts to improve your Mental Health", 5);
                    reflectionActivity.Run();
                    // reflectionActivity.Run();
                    break;
                case "3":
                    // ListingActivity listingActivity
                    ListingActivity listingActivity = new ListingActivity("Listing", "List your thoughts", 5);
                    listingActivity.Run();
                    // listingActivity.Run();
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        
    }
} 