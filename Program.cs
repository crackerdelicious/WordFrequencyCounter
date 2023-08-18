using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Frequency Counter.\n");

            string choice;
            do
            {
                Console.Write("Enter the text: ");
                string text = Console.ReadLine();

                Dictionary<string, int> wordFrequency = CountWordFrequency(text);

                Console.WriteLine("Word Frequencies:");
                foreach (var pair in wordFrequency)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }

                Console.Write("\nDo you want to analyze more text? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

            Console.WriteLine("Goodbye!");
        }

        static Dictionary<string, int> CountWordFrequency(string text)
        {
            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '"' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

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