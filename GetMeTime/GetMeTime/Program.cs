namespace GetMeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime getMyTime = new DateTime(2024,8,8);
            Console.WriteLine("My Birthday is {0}", getMyTime);

            //get date time of today 
            Console.WriteLine("Todays Date is : {0}", DateTime.Today);
            // get date time of now 
            Console.WriteLine("Time now is : {0} ", DateTime.Now);
            // get date of tomorrow 
            Console.WriteLine("Tomorrow Date is : {0}", GetMeTime.Program.getTomorrow());
            // get day of the week 
            Console.WriteLine($"The Day of the Week is : {DateTime.Today.DayOfWeek}");

            DateTime firstDay = new DateTime(2005, 1, 1);
            Console.WriteLine($"First Day of the Year 2005 is {firstDay}");

            int currentYear_daysInFeb = DateTime.DaysInMonth(2025, 2);
            Console.WriteLine($"Days in February for 2025 is : {currentYear_daysInFeb}");

            //Current Minutes 
            DateTime now = DateTime.Now;
            Console.WriteLine($"Minutes is {now.Minute}");

            // Full Date and Time is 
            DisplayCurrentTime();

            

            // Write a program to find out the days passed 
            Console.WriteLine("Write a date in the following format : yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out getMyTime))
            {
                Console.WriteLine(getMyTime);
                TimeSpan daysPassed = now.Subtract(getMyTime);
                Console.WriteLine($"Days Passed since : {daysPassed.Days}");
            }
            else
            {
                Console.WriteLine("Wromg Output");
            }

                Console.ReadKey();
        }

        static DateTime getTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static void DisplayCurrentTime()
        {
            DateTime now = DateTime.Now;

            int hour = now.Hour % 12;
            if (hour == 0) hour = 12; // Handle 12 AM and 12 PM

            int minutes = now.Minute;
            int seconds = now.Second;

            string period = now.Hour >= 12 ? "PM" : "AM";

            Console.WriteLine($"It's {hour} o'clock, {minutes} minutes and {seconds} seconds {period}.");
        }
    }
}
