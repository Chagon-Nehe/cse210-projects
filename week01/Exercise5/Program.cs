using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("BYU-Idaho CSE 210");
        DisplayWelcome();
        string userName = "";
        userName = PromptUserName( userName);
        DisplayResult(userName, SquareNumber(PromptUserNumber(0)));

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program.");
    }

    static string PromptUserName(string userName)
    {
        Console.Write("Enter user name: ");
        string userPrompt = Console.ReadLine();
        userName = userPrompt;
        Console.WriteLine($"{userName}");
        return userName;

    }
    static int PromptUserNumber(int userNumber)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        userNumber = int.Parse(input);
        Console.WriteLine($" {userNumber}");
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}