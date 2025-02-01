using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("=== Duplicate Number Checker ===");
        Console.WriteLine("Enter numbers (enter -1 to stop)");

        while (true)
        {
            try
            {
                Console.Write("\nEnter a number: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a number!");
                    continue;
                }

                int number = Convert.ToInt32(input);
                
                if (number == -1)
                    break;
                
                if (numbers.Contains(number))
                {
                    Console.WriteLine($"Error: {number} is already in the list! Try another number.");
                    continue;
                }
                numbers.Add(number);
                Console.WriteLine($"Added {number} to the list.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        if (numbers.Count == 0)
        {
            Console.WriteLine("\nNo numbers were entered.");
        }
        else
        {
            Console.WriteLine("\nYour unique numbers are:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}