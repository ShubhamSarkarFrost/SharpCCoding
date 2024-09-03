
namespace ListSelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings
            List<string> words = new List<string> { "apple", "orange", "banana", "grape", "pear" };

            // Call the SelectionSort method to sort the list
            SelectionSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted list:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }

        static void SelectionSort(List<string> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in the unsorted part of the list
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(list[j], list[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                string temp = list[minIndex];
                list[minIndex] = list[i];
                list[i] = temp;
            }
        }
    }
}
