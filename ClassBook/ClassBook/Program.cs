namespace ClassBook
{
    public class Book
    {
        public String title { get; set; }
        public String author { get; set; }

        public Book()
        {
            this.title = "Deathly Hollows";
            this.author = "J.K.Rowling";
            Console.WriteLine($"Default Constructor Called - {this.title} - {this.author}");
        }

        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
            Console.WriteLine($"Parameterized Constructor Called -{this.title} - {this.author}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book();

            Console.WriteLine();

            Book book2 = new Book("The Hobbit", "J.R.R. Tolkien");

            Console.ReadKey();
        }
    }
}
