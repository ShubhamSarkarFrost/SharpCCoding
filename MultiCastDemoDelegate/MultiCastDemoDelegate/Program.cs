namespace MultiCastDemoDelegate
{
    public delegate void NotifyUser(string message);

    public class NotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"📧 Email sent: {message}");
        }

        public void SendSMS(string message)
        {
            Console.WriteLine($"📱 SMS sent: {message}");
        }

        public void SendAppNotification(string message)
        {
            Console.WriteLine($"🔔 App notification: {message}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();

            NotifyUser notify = service.SendEmail;
            notify += service.SendSMS;
            notify += service.SendAppNotification;

            foreach(NotifyUser notifyUser in NotifyUser.Get)

            // Step 3: Call using safe invocation method
            Console.WriteLine("Sending notifications...\n");
            invokeSafely(notify, "Your order has been shipped!");

            Console.WriteLine("\nLog written to 'notifications.log'. Press any key to exit.");

            Console.ReadKey();
        }

        static void invokeSafely(NotifyUser notify, string message)
        {
            NotifyUser tempNotify = notify;
            if(tempNotify != null)
            {
                tempNotify(message);
            }
        }
    }
}
