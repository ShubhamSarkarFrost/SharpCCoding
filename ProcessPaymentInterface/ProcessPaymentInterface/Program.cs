namespace ProcessPaymentInterface
{   
    interface IPayment
    {
        void ProcessPayment(double amount);
    }
    class CreditCardPayment : IPayment
    {
        private double balance;
        public CreditCardPayment(double initialBalance)
        {
            balance = initialBalance;
        }
        public void ProcessPayment(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Credit Card Payment Successful! Remaining Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds on Credit Card.");
            }
        }
    } 

    class PayPalPayment : IPayment
{
    private double balance;

    public PayPalPayment(double initialBalance)
    {
        balance = initialBalance;
    }

    public void ProcessPayment(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"PayPal Payment Successful! Remaining Balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Insufficient PayPal balance.");
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize payment methods with different balances
            IPayment payment1 = new CreditCardPayment(500.00);
            IPayment payment2 = new PayPalPayment(300.00);

            // Process payments with actual calculations
            payment1.ProcessPayment(150.00);
            payment2.ProcessPayment(350.00); // This will trigger an "Insufficient funds" message
            Console.ReadKey();
        }
    }
}
