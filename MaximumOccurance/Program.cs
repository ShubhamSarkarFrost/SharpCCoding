using static System.Net.Mime.MediaTypeNames;

namespace MaximumOccurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Sentence to find maximum Frequency For");
            String sentence = Console.ReadLine();
            String MaxOccurance = MaxOccuranceWord(Sentence:sentence);
            Console.WriteLine($"Maximum Occurance Word is {MaxOccurance}");
            Console.ReadKey();
        }

        static String MaxOccuranceWord(String Sentence)
        {
            char[] delimiters = new char[] { ' ', '.', ',', ';', ':', '!', '?' };
            string[] words = Sentence.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Sort the array of words
            Array.Sort(words);

            // Initialize variables to track the word with maximum occurrence
            string maxword = words[0];
            int maxcount = 1;
            int currentCount = 1;

            // Iterate through the sorted array and count occurrences
            for (int i = 1; i< words.Length; i++)
            {
                if (words[i] == words[i - 1])
                {
                    currentCount++;
                }else
                {
                    if(currentCount > maxcount)
                    {
                        maxcount = currentCount;
                        maxword = words[i - 1];
                    }
                    currentCount = 1;
                }
            }

            // Check the last word group
            if (currentCount > maxcount)
            {
                maxcount = currentCount;
                maxword = words[words.Length - 1];
            }

            return maxword;

        }
    }
}
