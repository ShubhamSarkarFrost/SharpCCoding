namespace ConstructorMultipleDerivedClasses
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        // Default Constructor
        public Employee()
        {
            Console.WriteLine("Employee: Default constructor called");
        }

        // Parameterized Constructor
        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
            Console.WriteLine($"Employee: Name - {name}, ID - {id}");
        }

        // Method to Display Employee Details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee Details -> Name: {Name}, ID: {Id}");
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        // Default Constructor
        public Manager() : base()
        {
            Console.WriteLine("Manager: Default constructor called");
        }

        // Parameterized Constructor
        public Manager(string name, int id, int teamSize) : base(name, id)
        {
            TeamSize = teamSize;
            Console.WriteLine($"Manager: Team Size - {teamSize}");
        }

        // Overriding DisplayDetails
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Manager Details -> Team Size: {TeamSize}");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        // Default Constructor
        public Developer() : base()
        {
            Console.WriteLine("Developer: Default constructor called");
        }

        // Parameterized Constructor
        public Developer(string name, int id, string language) : base(name, id)
        {
            ProgrammingLanguage = language;
            Console.WriteLine($"Developer: Programming Language - {language}");
        }

        // Overriding DisplayDetails
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Developer Details -> Programming Language: {ProgrammingLanguage}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating default Manager:");
            Manager mgr1 = new Manager();
            mgr1.DisplayDetails();

            Console.WriteLine("\nCreating parameterized Manager:");
            Manager mgr2 = new Manager("Alice", 101, 5);
            mgr2.DisplayDetails();

            Console.WriteLine("\nCreating default Developer:");
            Developer dev1 = new Developer();
            dev1.DisplayDetails();

            Console.WriteLine("\nCreating parameterized Developer:");
            Developer dev2 = new Developer("Bob", 102, "C#");
            dev2.DisplayDetails();
            Console.ReadKey();
        }
    }
}
