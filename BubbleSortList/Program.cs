
namespace BubbleSortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings
            List<string> words = new List<string> { "apple", "orange", "banana", "grape", "pear" };

            // Call the BubbleSort method to sort the list
            BubbleSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted list:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }

        private static void BubbleSort(List<string> words)
        {
            int n = words.Count;

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n -i - 1; j++)
                {
                    if (String.Compare(words[j], words[j+1] )> 0)
                    {
                        String temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }
        }
    }
}
