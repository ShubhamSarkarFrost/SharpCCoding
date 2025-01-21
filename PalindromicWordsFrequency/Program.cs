namespace PalindromicWordsFrequency
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter a sentence
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // Convert the sentence to lowercase and split it into words
            char[] delimiters = { ' ', '.', ',', '!', '?' };
            string[] words = sentence.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Create a dictionary to store word frequencies
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            // List to store palindromic words
            List<string> palindromicWords = new List<string>();

            // Count the frequency of each word and check for palindromes
            foreach (string word in words)
            {
                // Check if the word is a palindrome
                if (IsPalindrome(word) && !palindromicWords.Contains(word))
                {
                    palindromicWords.Add(word);
                }

                // Update word frequency
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            // Display the word frequencies
            Console.WriteLine("\nWord Frequencies:");
            foreach (KeyValuePair<string, int> entry in wordFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Display the palindromic words
            Console.WriteLine("\nPalindromic Words:");
            if (palindromicWords.Count > 0)
            {
                Console.WriteLine(string.Join(", ", palindromicWords));
            }
            else
            {
                Console.WriteLine("No palindromic words found.");
            }

            Console.ReadKey();
        }

        // Method to check if a word is a palindrome
        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}