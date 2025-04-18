namespace EnumCoffeeShop
{
    enum CoffeeSize{
        Small,
        Medium,
        Large,
        ExtraLarge
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the User for Coffee Size 
            Console.WriteLine("Choose the Coffee Size :");
            Console.WriteLine("0 - Small\n1 - Medium\n2 - Large\n3 - ExtraLarge");

            int choice = Convert.ToInt32(Console.ReadLine());
            CoffeeSize selectedsize = (CoffeeSize)choice;

            // Print the selected size and the corresponding price
            double price = GetCoffeePrice(selectedsize);
            Console.WriteLine($"\nYou selected {selectedsize} coffee. Price: ${price:F2}");
            Console.ReadKey();
        }

        // Method to get the price based on coffee size
        static double GetCoffeePrice(CoffeeSize size)
        {
            switch (size)
            {
                case CoffeeSize.Small:
                    return 2.50;
                case CoffeeSize.Medium:
                    return 3.00;
                case CoffeeSize.Large:
                    return 3.50;
                case CoffeeSize.ExtraLarge:
                    return 4.00;
                default:
                    return 0.0;
            }
        }
    }
}
}
