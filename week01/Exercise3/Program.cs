using System;

class Program
{
    static void Main(string[] args)

    {
        // This program generates a random number between 1 and 100 and asks the user to guess it.
        int guess;
        int magicNumber;
        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 100);

        //do while loop to keep asking the user for a guess until they guess the magic number
        do
        {
            Console.Write("What is your guess? ");
            string guessValue = Console.ReadLine();
            guess = int.Parse(guessValue);


            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations You guessed the magic number!");

            }
            else if (guess < magicNumber)
            {
                Console.WriteLine(" Higher.");



            }
            else if (guess > magicNumber)
            {
                Console.WriteLine(" Lower. ");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
        } while (guess < magicNumber || guess > magicNumber);


        


    }    
}
// The program will continue to ask the user for a guess until they guess the magic number.