namespace catchMeTry
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a numerator:");
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a denominator:");
                int denominator = int.Parse(Console.ReadLine());

                // Perform division
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be zero.");
                }

                int result = Divide(numerator, denominator);
                Console.WriteLine($"Result: {result}");

                // Simulating another potential exception
                ProcessData("invalid");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Math Error: {ex.Message}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch-all for unexpected exceptions
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution complete. Cleaning up resources if any.");
            }
            Console.ReadKey();
        }

        // Method to perform division
        static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        // Method to simulate processing data
        static void ProcessData(string data)
        {
            if (data == "invalid")
            {
                throw new CustomException("Data processing failed due to invalid input.");
            }

            Console.WriteLine("Data processed successfully.");
        }
    }

    // Custom exception class
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
