namespace DayWeekEnums
{
    public enum DaysOfWeek
    {
        Sunday,     // 0
        Monday,     // 1
        Tuesday,    // 2
        Wednesday,  // 3
        Thursday,   // 4
        Friday,     // 5
        Saturday    // 6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assign enum value
            DaysOfWeek today = DaysOfWeek.Monday;
            Console.WriteLine($"Today is {today} (value: {(int)today})"); 

        // Check if it's a weekday
        if (today >= DaysOfWeek.Monday && today <= DaysOfWeek.Friday)
            {
                Console.WriteLine("It's a weekday!"); 
        }
            else
            {
                Console.WriteLine("It's the weekend!");
            }

            // Print all enum values using loop
            Console.WriteLine("\nAll days of the week:");
            foreach (DaysOfWeek day in Enum.GetValues<DaysOfWeek>())
            {
                Console.WriteLine($"{day} = {(int)day}"); 
        }

            // Input from user and parse
            Console.Write("\nEnter a day (e.g., Wednesday): ");
            if (Enum.TryParse<DaysOfWeek>(Console.ReadLine(), true, out DaysOfWeek userDay))
            {
                Console.WriteLine($"You entered: {userDay}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            Console.ReadKey();
        }
    }
}
