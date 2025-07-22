using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // The 'Program' class interacts with the abstracted 'Journal' class.
        // It doesn't need to know the internal workings of how entries are stored
        // or how files are handled.
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to your Journal Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt(); // Abstraction in action
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string userEntryText = Console.ReadLine();
                    Entry newEntry = new Entry(randomPrompt, userEntryText); // Abstraction in action
                    myJournal.AddEntry(newEntry); // Abstraction in action: high-level operation
                    break;
                case "2":
                    myJournal.DisplayAllEntries(); // Abstraction in action: high-level operation
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile); // Abstraction in action: high-level operation
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile); // Abstraction in action: high-level operation
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}