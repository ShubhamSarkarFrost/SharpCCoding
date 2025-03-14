namespace Constructor_Inheritence_Example
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent class defult constructor");

        }
        public Parent(string message)
        {
            Console.WriteLine("Parent Class Parameterized Constructor" + message);
        }
    }

    class Child : Parent
    {
        public Child() : base() // Calls Parent() constructor
        {
            Console.WriteLine("Child class default constructor");
        }

        public Child(string message) : base(message) // Calls Parent(string) constructor
        {
            Console.WriteLine("Child class parameterized constructor: " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object with default constructor:");
            Child child1 = new Child();

            Console.WriteLine("\nCreating object with parameterized constructor:");
            Child child2 = new Child("Hello from Child");

            Console.ReadKey();
        }
    }
}
