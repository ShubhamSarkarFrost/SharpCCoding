namespace ListWithObjects
{
    class Program
    {
        // Define a Person class
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            public Person(string name, int age, string city)
            {
                Name = name;
                Age = age;
                City = city;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, City: {City}";
            }
        }

        static void Main()
        {
            // Create a list of Person objects
            List<Person> people = new List<Person>();

            // Add some Person objects to the list
            people.Add(new Person("Alice", 30, "New York"));
            people.Add(new Person("Bob", 25, "Los Angeles"));
            people.Add(new Person("Charlie", 35, "Chicago"));

            // Display all people in the list
            Console.WriteLine("List of People:");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            // Search for a person by name
            Console.WriteLine("\nEnter a name to search for:");
            string searchName = Console.ReadLine();

            Person foundPerson = people.Find(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (foundPerson != null)
            {
                Console.WriteLine($"Found: {foundPerson}");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            // Find all people older than a certain age
            Console.WriteLine("\nEnter an age to find people older than that age:");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                List<Person> olderPeople = people.FindAll(p => p.Age > age);
                Console.WriteLine($"People older than {age}:");
                foreach (Person person in olderPeople)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

            Console.ReadKey();
        }
    }
}
