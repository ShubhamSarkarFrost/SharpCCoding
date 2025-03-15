namespace LogFileCreation
{
    class Logger
    {
        private string logFilePath;

        public Logger(string fileName)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Set the full path of the log file in the same directory
            logFilePath = Path.Combine(currentDirectory, fileName);

            if (!File.Exists(logFilePath))
            {
                using (FileStream fs = new FileStream(logFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    fs.Close();
                }
            }
        }
    public void WriteLog(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";

            // Use FileStream to avoid file locking issues
            using (FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(logEntry);
            }

            Console.WriteLine($"Log written successfully in: {logFilePath}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string logFilePath = "application_log.txt";
            Logger logger = new Logger(logFilePath);

            // Writing logs
            logger.WriteLog("Application started.");
            logger.WriteLog("User logged in.");
            logger.WriteLog("Error: Unable to connect to database.");
            Console.ReadKey();
        }
    }
}
