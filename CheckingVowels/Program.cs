using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Vowel Checker ===");

        while (true)
        {
            try
            {
                Console.Write("\nEnter a string (or press Enter to exit): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                CheckForVowels(input);
                Console.WriteLine("✓ The string contains at least one vowel!");
                
                ShowVowelsFound(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    
    static void CheckForVowels(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Input string cannot be empty!");
        }

        text = text.ToLower();
        
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        bool hasVowel = false;
        
        foreach (char vowel in vowels)
        {
            if (text.Contains(vowel))
            {
                hasVowel = true;
                break;
            }
        }
        
        if (!hasVowel)
        {
            throw new Exception("The string does not contain any vowels!");
        }
    }

    static void ShowVowelsFound(string text)
    {
        text = text.ToLower();
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        Console.Write("Vowels found: ");
        
        foreach (char vowel in vowels)
        {
            if (text.Contains(vowel))
            {
                Console.Write($"{vowel} ");
            }
        }
        Console.WriteLine();
    }
}