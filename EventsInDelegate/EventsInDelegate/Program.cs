namespace EventsInDelegate
{   
    // declaration 
    public delegate int Comparison<T> (T x, T y);

    public class Person
    {
        public int Age {  get; set; }
        public required string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for(int i = 0; i< people.Length - 1; i++)
            {
                for(int j = i+ 1; j< people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                    new Person { Name = "Alice", Age = 30 },
                    new Person { Name = "Bob", Age = 25 },
                    new Person { Name = "Charlie", Age = 35 }
            };

            PersonSorter sorter = new PersonSorter();

            Console.WriteLine("Sorting by Age:");
            sorter.Sort(people, (p1, p2) => p1.Age.CompareTo(p2.Age));
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - Age {person.Age}");
            }

            Console.WriteLine("\nSorting by Name:");
            sorter.Sort(people, (p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - Age {person.Age}");
            }


            Console.ReadKey();
        }
    }
}
