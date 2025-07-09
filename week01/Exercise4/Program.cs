using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("You entered 0, ending input.");
                break;
            }
        } while (numbers[numbers.Count - 1] != 0); // Continue until 0 is entered
        Console.WriteLine($"Your list of numbers is: {string.Join(", ", numbers)}");
        // Check if the list is empty before calculating sum, average, max, min, and sorting
        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            //print the sum and average of the numbers
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {((decimal)average):F2}");
            int max = numbers[0];
            int min = numbers[0];
            int? smallPositiveNum = null;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                if (number > 0 )
                {
                    if (smallPositiveNum == null || number < smallPositiveNum)
                    {
                        smallPositiveNum = number;// If smallPositiveNum is null or the current number is smaller, update it
                    }
                    
                }
            }
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest number is: {min}");
            Console.WriteLine($"The smallest positive number is: {smallPositiveNum}");
            // Sort the list of numbers
            numbers.Sort();
            Console.WriteLine($"The sorted list of numbers is: {string.Join(", ", numbers)}");
        }  
            
    }
}