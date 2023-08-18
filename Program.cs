namespace WordFrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jump over the lazy dog.";

            string[] splitedWords = sentence.Split(' ', 9);

            foreach (string word in splitedWords)
            {
                Console.WriteLine(word);
            }

            // CountWordFrequency(sentence);
        }

        static void CountWordFrequency(string sentence)
        {
            char[] punctuation = { '.', '-', '!', ':', ';', '&', '/', '\\', '|', '`', '\'', '?', ' ' };
            string[] words = sentence.Split(punctuation);

            foreach (string word in words)
            {
                Console.WriteLine(word.ToLower());
            }
        }
    }
}