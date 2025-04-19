namespace MathMagic
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Ceiling of a double type number
            Console.WriteLine("Ceiling" + Math.Ceiling(15.3));
            //Floor of a double type number 
            Console.WriteLine("Floor of a number " + Math.Floor(15.3));

            int num_one = 13;
            int num_two = 9;

            //Maximum of two number 
            Console.WriteLine($"Maximum of {num_one} & {num_two} is {Math.Max(num_two, num_one)}");
            // Minimum of two number
            Console.WriteLine($"Maximum of {num_one} & {num_two} is {Math.Min(num_two, num_one)}");

            Console.ReadKey();
        }
    }
}
