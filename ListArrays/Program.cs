using System.Collections;

namespace ListArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList arrayList = new ArrayList();

            // Add elements of different types to the ArrayList
            arrayList.Add(10);              // Integer
            arrayList.Add(20.5);            // Double
            arrayList.Add("Hello World");   // String
            arrayList.Add(true);            // Boolean

            // Display all elements in the ArrayList
            Console.WriteLine("ArrayList elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Insert an element at a specific index
            arrayList.Insert(2, "Inserted Element");
            Console.WriteLine("\nAfter insertion:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Remove an element
            arrayList.Remove(10); // Removes the first occurrence of the element
            Console.WriteLine("\nAfter removing 10:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Access an element by index
            Console.WriteLine($"\nElement at index 2: {arrayList[2]}");

            // Check the count of elements
            Console.WriteLine($"\nCount of elements in ArrayList: {arrayList.Count}");

            // Clear all elements
            arrayList.Clear();
            Console.WriteLine("\nAfter clearing the ArrayList:");
            Console.WriteLine($"Count: {arrayList.Count}");

            Console.ReadKey();
        }
    }
}
