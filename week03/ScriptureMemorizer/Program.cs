using System;

class Program
{
    static void Main(string[] args)
    {
        // press Enter to hide random words in the scripture. Type Quit to exit.
        // Create a new scripture reference and text
        Reference myReference = new Reference("John", 3, 16);
        Scripture myScripture = new Scripture(myReference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Clear(); // Clear console initially

        while (!myScripture.CompletelyHidden())
        {
            Console.Clear(); // Clear console for fresh display
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput?.ToLower() == "quit")
            {
                break; // Exit the loop if user types 'quit'
            }

            // Hide a few random words each time
            myScripture.HideRandomWords(3); // You can adjust this number
        }

        Console.Clear();
        Console.WriteLine(myScripture.GetDisplayText()); // Show final state
        Console.WriteLine("\nAll words are now hidden! Program will now exit.");
        Thread.Sleep(2000); // Pause for 2 seconds before exiting
    }
}