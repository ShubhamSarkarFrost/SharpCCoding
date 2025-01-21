namespace ImplementThrows
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                // Call a method that may throw an exception
                CheckNumber(number);
                Console.WriteLine("The number is valid.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input is not a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }

        static void CheckNumber(int number)
        {
            // Validate the number and throw exceptions for invalid inputs
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number cannot be negative.");
            }

            if (number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number cannot be greater than 100.");
            }
        }
    }
}
