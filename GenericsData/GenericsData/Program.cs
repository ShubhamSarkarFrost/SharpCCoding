namespace GenericsData
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] integerArray = { 1, 2, 3, 4, 5, 6 };
            string[] fruitsName = { "apple", "guava", "Mango", "pineapple", "jackfruit" };
            PrintArray(integerArray);
            PrintArray(fruitsName);
            Console.ReadKey();

        }

        public static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
