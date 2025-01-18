using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PredicateOddEven
{
    internal class Program
    {
        static bool isEven(int num)
        {
            return num % 2 == 0;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the Number sepearted by Commas");
            string input = Console.ReadLine();

            foreach(string numStr in input.Split(','))
            {
                if (int.TryParse(numStr, out int num))
                {
                    numbers.Add(num);
                }
            }

            Predicate<int> predicate = isEven;

            // Use FindAll with the Predicate<int> delegate
            List<int> evenNumbers = numbers.FindAll(predicate);

            // Display the even numbers
            Console.WriteLine("Even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
