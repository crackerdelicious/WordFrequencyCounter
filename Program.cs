using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a greeting message
            Console.WriteLine("Word Frequency Counter.\n"); 

            /* 
             * Repeatly prompt the user for text input and analyze word frequencies until the user choose to quit. 
             */
            string choice;
            do
            {
                // Prompts the user to enter text and store it to the `text` variable.
                Console.Write("Enter the text: ");
                string text = Console.ReadLine();

                // Store word frequencies
                Dictionary<string, int> wordFrequency = CountWordFrequency(text);

                // Iterate through the key-value pairs in the dictionary and displays each word with its frequency.
                Console.WriteLine("Word Frequencies:");
                foreach (var pair in wordFrequency)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                // Stored user's choice in the `choice` variable
                Console.Write("\nDo you want to analyze more text? (y/n): ");
                choice = Console.ReadLine();

                // Loop continues if the user chooses to analyze more text. Otherwise, the loop ends.
            } while (choice.ToLower() == "y");

            // If the user chooses to quit, the program displays a "Goodbye!" messsage.
            Console.WriteLine("Goodbye!");
        }

        static Dictionary<string, int> CountWordFrequency(string text)
        {
            /*
             * Takes the input text and analyzes it to count word frequencies.
             * Split text into words using various punctuation marks and symbols as separators.
             * The result is an array of words.             
             */
            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '"' }, StringSplitOptions.RemoveEmptyEntries);

           
            //Store words using dictionary and use a case-insensitive comparison.
            Dictionary<string, int> frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            /*
             * Iterates through the array of words:
             * - if the word already exists in the dictionary, its frequency is incremented.
             * - if the word is encountered for the first time, it's added to the dictionary with a frequency of 1.
             */
            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }
            return frequency;
        }
    }
}