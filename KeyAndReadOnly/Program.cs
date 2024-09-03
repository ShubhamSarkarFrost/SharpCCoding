namespace KeyAndReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();
            // as the property is readonly we cannot assign but we do can read customer3.Id = 3; 
            Console.WriteLine(customer3.Id);


            Console.ReadKey();
        }
    }
}
