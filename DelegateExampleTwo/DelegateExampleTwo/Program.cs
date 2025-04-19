namespace DelegateExampleTwo
{
    // 1 - creation of a delegate 
    public delegate void LogHandler(string messaage);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log " + message);
        }

        public void LogToFile(string message)
        {
            string fileName = "logfile.txt";
            // Get the path of the directory where the program is running
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;

            // combine directory and file name 
            string filePath = Path.Combine(currentDir, fileName);

            // Append the message to the file with a timestamp
            using StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            sw.Close();
            Console.WriteLine("Logged into File" + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Implementation
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to Console");

            // over write Log to File 
            logHandler = logger.LogToFile;
            logHandler("Logging the Data into File");

            Console.ReadKey();
        }
    }
}
