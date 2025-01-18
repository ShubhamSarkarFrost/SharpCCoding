using System.Collections;

namespace TableHashes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            //Add key Value Pairs in Hashtable 
            hashtable.Add(1, "Apple");
            hashtable.Add(2, "Banana");
            hashtable.Add(3, "Orange");

            //Display all key Value Pairs
            Console.WriteLine("Display all Hashtable elements");

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key is {entry.Key} and Value is {entry.Value}");
            }

            // Update the value for an existing key
            hashtable[2] = "Blueberry";
            Console.WriteLine("\nAfter updating value for key 2:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // Check if a key exists
            int keyToCheck = 4;
            if (hashtable.ContainsKey(keyToCheck))
            {
                Console.WriteLine($"\nKey {keyToCheck} exists with value: {hashtable[keyToCheck]}");
            }
            else
            {
                Console.WriteLine($"\nKey {keyToCheck} does not exist.");
            }

            // Remove an entry by key
            hashtable.Remove(1);
            Console.WriteLine("\nAfter removing key 1:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // Count the number of entries
            Console.WriteLine($"\nTotal number of entries: {hashtable.Count}");

            // Clear all entries
            hashtable.Clear();
            Console.WriteLine("\nAfter clearing the Hashtable:");
            Console.WriteLine($"Count: {hashtable.Count}");

        }
    }
}
