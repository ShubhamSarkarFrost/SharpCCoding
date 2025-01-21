namespace DownWithInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Dog class
            Dog mydog = new Dog("Darius", 14, "German Shephard");
            mydog.Bark();
            mydog.DisplayInfo();

            // Create an instance of the Cat class
            Cat myCat = new Cat("Whiskers", 2, "Black");
            myCat.DisplayInfo();
            myCat.Meow();

            Console.ReadKey();
        }
    }

    // parent class
    class Animal
    {   
        // define member variables
        public string Name { get; set; }
        public int Age { get; set; }

        // define constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display basic information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // derived class - child class
    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        // Method specific to Dog
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking! Woof Woof!");
        }

        // Overriding DisplayInfo to include Breed
        public new void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method
            Console.WriteLine($"Breed: {Breed}");
        }
    }

    class Cat : Animal
    {
        public string FurColor { get; set; }
        public Cat(string name, int age, string furColor): base(name, age)
        {
            FurColor = furColor;
        }

        // Method specific to Cat
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing! Meow!");
        }

        // Overriding DisplayInfo to include FurColor
        public new void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method
            Console.WriteLine($"Fur Color: {FurColor}");
        }
    }
 }
