namespace FinaallReferenceList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List of Even Numbers
            List<int> even_numbers = numbers.FindAll(x => x % 2 == 0);

            Console.WriteLine("Even Numbers are:");
            foreach(int num in even_numbers)
            {

            Console.WriteLine(num); 
            }
            Console.ReadKey();

        }
    }
}
