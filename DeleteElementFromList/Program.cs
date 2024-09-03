namespace DeleteElementFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List to store string data
            List<string> stringList = new List<string>();

            // Get the number of inputs from the user
            Console.Write("Enter the number of inputs: ");
            int numberOfInputs = int.Parse(Console.ReadLine());

            // Loop to get user inputs and add them to the List
            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.Write($"Enter input {i + 1}: ");
                string userInput = Console.ReadLine();
                stringList.Add(userInput);
            }

            // Display the list before removal
            Console.WriteLine("\nThe elements in the List are:");
            foreach (string item in stringList)
            {
                Console.WriteLine(item);
            }

            // Ask the user to enter the element they want to remove
            Console.Write("\nEnter the element you want to remove: ");
            string elementToRemove = Console.ReadLine();

            // Remove the element from the List
            if (stringList.Remove(elementToRemove))
            {
                Console.WriteLine($"\n'{elementToRemove}' has been removed from the list.");
            }
            else
            {
                Console.WriteLine($"\n'{elementToRemove}' was not found in the list.");
            }

            // Display the list after removal
            Console.WriteLine("\nThe elements in the List after removal are:");
            foreach (string item in stringList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
