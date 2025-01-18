namespace valNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare nullable variables
            int? nullableInt = null;
            double? nullableDouble = 42.5;

            // Display the nullable variables
            Console.WriteLine($"nullableInt: {nullableInt}");
            Console.WriteLine($"nullableDouble: {nullableDouble}");

            // Check if the variables have a value
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"nullableInt has a value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("nullableInt does not have a value.");
            }

            if (nullableDouble.HasValue)
            {
                Console.WriteLine($"nullableDouble has a value: {nullableDouble.Value}");
            }
            else
            {
                Console.WriteLine("nullableDouble does not have a value.");
            }

            // Use the null-coalescing operator
            int defaultValue = nullableInt ?? 100; // Assign 100 if nullableInt is null
            Console.WriteLine($"\nUsing null-coalescing operator, value: {defaultValue}");

            // Assign a value to nullableInt
            nullableInt = 25;

            // Use GetValueOrDefault method
            Console.WriteLine($"\nnullableInt (GetValueOrDefault): {nullableInt.GetValueOrDefault()}");
            Console.WriteLine($"nullableDouble (GetValueOrDefault): {nullableDouble.GetValueOrDefault()}");

            // Null conditional operator
            Console.WriteLine($"\nnullableInt with ?.Value: {nullableInt?.ToString() ?? "null"}");

            Console.ReadKey();
        }
    }
}
