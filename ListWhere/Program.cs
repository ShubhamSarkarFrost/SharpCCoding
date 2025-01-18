using static ListWhere.Program;

namespace ListWhere
{

    class Program
    {
        // Define a Product class
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Price: {Price:C2}";
            }
        }

        static void Main()
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product("Laptop", 1200.00),
            new Product("Mouse", 25.50),
            new Product("Keyboard", 45.00),
            new Product("Monitor", 0.00), // Invalid price
            new Product("Charger", -10.00), // Invalid price
        };

            // Create a new list with products that have a price greater than 0.00
            List<Product> validProducts = products.Where(p => p.Price > 10.00).ToList();

            // Display the valid products
            Console.WriteLine("Products with a price greater than 0.00:");
            foreach (Product product in validProducts)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }
    }
}

