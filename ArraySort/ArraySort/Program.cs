namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of data to be stored in the list");
            int n = int.Parse(Console.ReadLine());
            String[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                arr[i] = Console.ReadLine();
            }

            //Sort the array
            Array.Sort(arr);

            Console.WriteLine("\nSorted array:");
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
